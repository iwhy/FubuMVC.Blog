using FubuMVC.Core;

namespace Blog.Authorization.Login
{
    public class GetHandler
    {
        [UrlPattern("login")]
        public LoginViewModel Execute(LoginInputModel inputModel)
        {
            return new LoginViewModel();
        }
    }
}