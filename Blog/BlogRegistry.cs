using System;
using System.Runtime.CompilerServices;
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

      Output.ToJson.WhenCallMatches(action => action.Method.ReturnParameter.HasAttribute<DynamicAttribute>());

      Services(registry =>
      {
        registry.SetServiceIfNone<IJsonWriter, NewtonSoftJsonWriter>();
      });
    }
  }
}