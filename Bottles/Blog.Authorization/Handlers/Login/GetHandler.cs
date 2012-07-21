using DotNetOpenAuth.OpenId.RelyingParty;

namespace Blog.Authorization.Login
{
    public class GetHandler
    {
        public LoginViewModel Execute(LoginInputModel inputModel)
        {
            var party = new OpenIdRelyingParty();
            var response = party.GetResponse();

            return new LoginViewModel();
        }
    }
}