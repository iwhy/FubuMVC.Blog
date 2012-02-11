using System;
using System.Collections.Generic;

namespace Blog.Article.Summaries
{
  public class GetHandler
  {
    public ArticleSummariesViewModel Execute()
    {
      return new ArticleSummariesViewModel
      {
        Summaries = new List<ArticleSummaryViewModel>
        {
          new ArticleSummaryViewModel
            {
              Author = "John Doe",
              Title = "Lorem ipsum dolor sit amet.",
              Uri = "lorem-ipsum-dolor-sit-amet",
              PublishedDate = DateTime.Now,
              Summary =
                "Lorem ipsum **dolor** sit amet, consectetur adipiscing elit. Morbi in urna eros. Sed ultricies magna tincidunt nisl ornare euismod. Donec vitae diam nunc. Cras vel pellentesque nulla. Donec non facilisis nisi. Nullam suscipit molestie eros, vitae porttitor tortor lobortis sit amet. Maecenas eget urna dui. Morbi nec augue tincidunt risus congue aliquam. <!--more-->" +
                "_Integer_ et consequat ipsum. Vivamus sodales venenatis neque ut pretium. Nam aliquam libero ac tellus malesuada quis porttitor nisl vehicula. Maecenas quis nunc lorem. Pellentesque scelerisque risus eu magna elementum tristique. Phasellus sapien ante, rhoncus id mollis laoreet, volutpat et risus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Phasellus dictum tincidunt viverra. Phasellus bibendum eleifend aliquet. Maecenas in arcu velit. Duis sodales pellentesque pellentesque. In porta, turpis pharetra interdum molestie, eros magna aliquet velit, eget dapibus dui turpis ac mauris. Duis non leo vel diam commodo egestas. Proin varius, diam sit amet pretium elementum, neque arcu fringilla lacus, ac tempus nibh felis id nisl. Aenean vestibulum condimentum lectus, eu tincidunt magna dictum quis."
            },
          new ArticleSummaryViewModel
            {
              Author = "John Doe",
              Title = "Aliquam nec sem purus, ut vulputate urna.",
              PublishedDate = DateTime.Now.AddDays(-2),
              Summary =
                "**Aliquam** nec sem purus, ut vulputate urna. Sed neque mi, congue vel sollicitudin sed, dignissim a mi. Proin congue blandit porttitor. Aliquam erat volutpat. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean auctor vehicula interdum. Duis quis lacus nec mauris malesuada eleifend. Pellentesque pharetra dapibus massa, semper convallis tellus interdum vitae. Praesent accumsan enim a dui ultrices nec molestie arcu semper. Pellentesque purus ante, aliquam quis lacinia eu, cursus eget massa." +
                "Suspendisse sed nulla erat. Suspendisse et nulla leo. Vivamus congue tincidunt bibendum. Maecenas in convallis nibh. Quisque hendrerit dolor ac nisi placerat molestie. Cras et ante quis ipsum viverra fermentum. Donec sed elit tellus, in elementum sem. Ut non tincidunt erat. Aliquam placerat justo id turpis sagittis ullamcorper."
            }
        }
      };
    }
  }
}