using System.Collections.Generic;
using Blog.Authorization.Policies;
using FubuMVC.Core.Registration;

namespace Blog.Authorization.Conventions
{
    public class AuthorizationConvention : IConfigurationAction
    {
        public void Configure(BehaviorGraph graph)
        {
            graph.Behaviors
                .Each(x => x.Authorization.AddPolicy(typeof(AuthorizationPolicy)));
        }
    }
}