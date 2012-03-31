using System.Runtime.CompilerServices;
using Blog.Behaviors;
using Blog.Home;
using FubuCore.Reflection;
using FubuMVC.Core;
using FubuMVC.Core.Runtime;
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
      Routes.HomeIs<GetHandler>(x => x.Execute());

      ApplyHandlerConventions();

      this.UseSpark();

      Views
          .TryToAttachWithDefaultConventions()
          .TryToAttachViewsInPackages();

      Output.ToJson.WhenCallMatches(action => action.Method.ReturnParameter.HasAttribute<DynamicAttribute>());

      Policies.WrapBehaviorChainsWith<RavenDbBehavior>();

      Services(registry =>
      {
        registry.SetServiceIfNone<IJsonWriter, NewtonSoftJsonWriter>();
      });
    }
  }
}