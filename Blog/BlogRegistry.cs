using Blog.Home;
using FubuMVC.Core;
using FubuMVC.Spark;

namespace Blog
{
    public class BlogRegistry : FubuRegistry
    {
        public BlogRegistry()
        {
            #if DEBUG
            IncludeDiagnostics(true);
            #endif

            Applies.ToAllPackageAssemblies();
            Actions.IncludeClassesSuffixedWithController();

            ApplyHandlerConventions();

            Routes
                .HomeIs<HomeController>(x => x.Index())
                .IgnoreControllerNamespaceEntirely()
                .IgnoreMethodSuffix("Index")
                .IgnoreMethodSuffix("Command")
                .IgnoreMethodSuffix("Query")
                .ConstrainToHttpMethod(action => action.Method.Name.EndsWith("Command"), "POST")
                .ConstrainToHttpMethod(action => action.Method.Name.StartsWith("Query"), "GET");

            this.UseSpark();

            Views
                .TryToAttachWithDefaultConventions()
                .TryToAttachViewsInPackages();

            Services(s => { });
        }
    }
}