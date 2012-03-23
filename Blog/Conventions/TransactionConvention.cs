using System.Collections.Generic;
using Blog.Behaviors;
using FubuMVC.Core.Registration;
using FubuMVC.Core.Registration.Nodes;

namespace Blog.Conventions
{
    public class TransactionConvention : IConfigurationAction
    {
        public void Configure(BehaviorGraph graph)
        {
            graph.Actions()
                .Each(x => x.AddBefore(new Wrapper(typeof (TransactionBehavior))));
        }
    }
}