using Blog.Core.Constants;
using FubuMVC.Core;
using FubuMVC.Core.UI.Navigation;

namespace Blog.About
{
    public class AboutRegistry : IFubuRegistryExtension
    {
        public void Configure(FubuRegistry registry)
        {
            registry.Navigation(x =>
            {
                x.ForMenu(StringConstants.BlogName);
                x.Add += MenuNode.ForInput<AboutInputModel>("About Author");
            });
        }
    }
}