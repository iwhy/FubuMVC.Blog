using System.Transactions;
using FubuMVC.Core.Behaviors;

namespace Blog.Behaviors
{
    public class TransactionBehavior : IActionBehavior
    {
        public IActionBehavior InsideBehavior { get; set; }

        public void Invoke()
        {
            var transactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = System.TimeSpan.FromMinutes(1)
            };

            using (var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions))
            {
                if (InsideBehavior != null)
                    InsideBehavior.Invoke();

                transactionScope.Complete();
            }
        }

        public void InvokePartial()
        {
            Invoke();
        }
    }
}