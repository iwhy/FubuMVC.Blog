using FubuMVC.Core.Continuations;
using FubuMVC.Core.Security;

namespace Blog.Authorization.Handlers.AuthorizationFailure
{
    public class AuthorizationFailureHandler : IAuthorizationFailureHandler
    {
        public void Handle()
        {
            FubuContinuation.RedirectTo<AuthorizationFailureInputModel>();
        }
    }
}