using System;
using System.Web;
using Bottles;
using FubuMVC.Core;
using FubuMVC.StructureMap;
using Raven.Client;
using Raven.Client.Document;
using StructureMap;

namespace Blog
{

    public class MvcApplication : HttpApplication
    {

        protected void Application_Start()
        {
            FubuApplication
                .For<BlogRegistry>()
                .StructureMap(() => new Container(SetupContainer))
                .Bootstrap();

            // If there is an error during bootstrapping, it will not automatically be considered
            // fatal and there will be no YSOD.  This is to help during initial debugging and 
            // troubleshooting package loading. Normally, however, you want a YSOD if there is
            // a bootstrapping failure or a package-loading failure. This next line ensures that.
            PackageRegistry.AssertNoFailures(); 
        }

        private static void SetupContainer(ConfigurationExpression x)
        {
            var documentStore = new DocumentStore
                {
                    Url = "http://localhost:8080",
                    DefaultDatabase = "MyBlog"
                }.Initialize();

            documentStore.Conventions.FindTypeTagName = t => t.Name.Replace("ViewModel", string.Empty);

            Func<IDocumentSession> getSession = documentStore.OpenSession;

            x.Scan(i =>
            {
                i.TheCallingAssembly();
                i.Convention<SettingsScanner>();
            });

            x.For<IDocumentSession>().HttpContextScoped().Use(getSession);

            x.For<IDocumentStore>().Singleton().Use(documentStore);
            x.SetAllProperties(s => s.Matching(p => p.Name.EndsWith("Settings")));
        }
    }
}