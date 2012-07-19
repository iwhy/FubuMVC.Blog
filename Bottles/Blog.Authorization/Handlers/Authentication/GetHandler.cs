namespace Blog.Authorization.Authentication
{
    public class GetHandler
    {
        public AuthenticationViewModel Execute(AuthenticationInputModel inputModel)
        {
            return new AuthenticationViewModel();
        }
    }
}