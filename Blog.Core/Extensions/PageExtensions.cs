using System.Collections.Generic;
using FubuMVC.Core.UI.Navigation;
using FubuMVC.Core.View;
using HtmlTags;

namespace Blog.Core.Extensions
{
    public static class PageExtensions
    {
        public static HtmlTag Menu(this IFubuPage page)
        {
            var service = page.Get<INavigationService>();
            var items = service.MenuFor(new NavigationKey("MyBlog"));
            var menu = new HtmlTag("ul");

            items.Each(x =>
            {
                var link = new LinkTag(x.Key, x.Url);
                var li = new HtmlTag("li");

                if (x.MenuItemState == MenuItemState.Active)
                {
                    li.AddClass("current");
                }

                menu.Append(li.Append(link));

            });

            return menu;
        }
    }
}