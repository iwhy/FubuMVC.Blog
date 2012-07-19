using Blog.Home;
using FubuMVC.Core.UI.Navigation;
namespace Blog
{
    public class BlogNavigationRegistry : NavigationRegistry
    {
        public BlogNavigationRegistry()
        {
            ForMenu("MyBlog");
            Add += MenuNode.ForInput<HomeInputModel>("Blog Home");
        }
    }
}
