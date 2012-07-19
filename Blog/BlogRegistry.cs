using Blog.Behaviors;
using Blog.Home;
using FubuMVC.Core;
using FubuMVC.Core.Registration.Conventions;
using FubuMVC.Core.Runtime;
using FubuMVC.Spark;

namespace Blog
{
    public class BlogRegistry : FubuRegistry
    {
        public BlogRegistry()
        {
            Import<SparkEngine>();
            Import<HandlerConvention>();

            Applies
                .ToThisAssembly()
                .ToAllPackageAssemblies();

            Routes.HomeIs<GetHandler>(x => x.Execute(null));

            Views.TryToAttachWithDefaultConventions();

            Navigation<BlogNavigationRegistry>();

            Policies.WrapBehaviorChainsWith<RavenDbBehavior>();

            Services(registry =>
            {
                registry.SetServiceIfNone<IJsonWriter, NewtonSoftJsonWriter>();
            });
        }
    }
}