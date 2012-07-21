using DotNetOpenAuth.OpenId.RelyingParty;

namespace Blog.Authorization.Login
{
    public class PostHandler
    {
        public PostHandler()
        {
        }

        public dynamic Execute(AuthenticateInputModel inputModel)
        {
            var party = new OpenIdRelyingParty();
            var response = party.GetResponse();

            //TODO: party.CreateRequest(inputModel.GetIdentifier());

            return null;
        }
    }
}
