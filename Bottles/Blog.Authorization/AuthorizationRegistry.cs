using Blog.Authorization.Conventions;
using Blog.Authorization.Login;
using Blog.Core.Constants;
using FubuMVC.Core;
using FubuMVC.Core.UI.Navigation;

namespace Blog.Authorization
{
    public class AuthorizationRegistry : IFubuRegistryExtension
    {
        public void Configure(FubuRegistry registry)
        {
            registry.Policies.Add<AuthorizationConvention>();


            registry.Navigation(x =>
            {
                x.ForMenu(StringConstants.BlogName);
                x.InsertAfter["About"] = MenuNode.ForInput<LoginInputModel>("Login");
            });

            registry.Services(x =>
            {
            });
        }
    }
}