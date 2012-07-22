using System.Collections.Generic;
using Blog.Core.Constants;
using FubuMVC.Core.Security;
using FubuMVC.Core.UI.Navigation;
using FubuMVC.Core.View;
using HtmlTags;

namespace Blog.Core.Extensions
{
    public static class PageExtensions
    {
        public static HtmlTag Menu(this IFubuPage page, string menuName = null)
        {
            var navigationService = page.Get<INavigationService>();
            var securityContext = page.Get<ISecurityContext>();
            var items = navigationService.MenuFor(new NavigationKey(menuName ?? StringConstants.BlogName));
            var menu = new HtmlTag("ul");


            items.Each(x =>
            {
                var link = new LinkTag(x.Key, x.Url);
                var li = new HtmlTag("li");

                if (x.Key.Equals("Logout") && x.MenuItemState == MenuItemState.Available)
                {
                    var spanTag = new HtmlTag("span");
                    spanTag.Text(string.Format("Welcome, {0}", securityContext.CurrentIdentity.Name));
                    menu.Append(spanTag);
                }

                if (x.MenuItemState == MenuItemState.Active)
                    li.AddClass("current");

                if(x.MenuItemState == MenuItemState.Active || x.MenuItemState == MenuItemState.Available)
                    menu.Append(li.Append(link));

            });

            return menu;
        }
    }
}