using Blog.Authorization.Authentication;
using Blog.Core.Constants;
using FubuMVC.Core;
using FubuMVC.Core.UI.Navigation;

namespace Blog.Authorization
{
    public class AuthorizationRegistry : IFubuRegistryExtension
    {
        public void Configure(FubuRegistry registry)
        {
            registry.Navigation(x =>
            {
                x.ForMenu(StringConstants.BlogName);
                x.InsertAfter["About"] = MenuNode.ForInput<AuthenticationInputModel>("Login");
            });
        }
    }
}