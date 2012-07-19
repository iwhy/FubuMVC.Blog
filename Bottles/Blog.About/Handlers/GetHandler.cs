using FubuMVC.Core.UI.Navigation;

namespace Blog.About
{
    public class GetHandler
    {
        [MenuItemAttribute("MyBlog")]
        public AboutViewModel Execute()
        {
            return new AboutViewModel();
        }

    }
}
