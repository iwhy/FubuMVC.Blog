﻿namespace Blog.Authorization.Handlers.AuthorizationFailure
{
    public class GetHandler
    {
         public AuthorizationFailureViewModel Execute(AuthorizationFailureInputModel inputModel)
         {
             return new AuthorizationFailureViewModel();
         }
    }
}