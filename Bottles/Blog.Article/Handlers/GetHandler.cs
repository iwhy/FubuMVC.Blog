using System;
using FubuMVC.Core;

namespace Blog.Article
{
  public class GetHandler
  {
    [UrlPattern("{Uri}")]
    public ArticleViewModel Execute(ArticleInputModel inputModel)
    {
      return new ArticleViewModel
      {
        Author = "John Doe",
        Title = "Lorem ipsum dolor sit amet.",
        Uri = "lorem-ipsum-dolor-sit-amet",
        PublishedDate = DateTime.Now,
        Body =
          "<p> Lorem ipsum **dolor** sit amet, consectetur adipiscing elit. Morbi in urna eros. Sed ultricies magna tincidunt nisl ornare euismod. Donec vitae diam nunc. Cras vel pellentesque nulla. Donec non facilisis nisi. Nullam suscipit molestie eros, vitae porttitor tortor lobortis sit amet. Maecenas eget urna dui. Morbi nec augue tincidunt risus congue aliquam. </p>" +
          "_Integer_ et consequat ipsum. Vivamus sodales venenatis neque ut pretium. Nam aliquam libero ac tellus malesuada quis porttitor nisl vehicula. Maecenas quis nunc lorem. Pellentesque scelerisque risus eu magna elementum tristique. Phasellus sapien ante, rhoncus id mollis laoreet, volutpat et risus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Phasellus dictum tincidunt viverra. Phasellus bibendum eleifend aliquet. Maecenas in arcu velit. Duis sodales pellentesque pellentesque. In porta, turpis pharetra interdum molestie, eros magna aliquet velit, eget dapibus dui turpis ac mauris. Duis non leo vel diam commodo egestas. Proin varius, diam sit amet pretium elementum, neque arcu fringilla lacus, ac tempus nibh felis id nisl. Aenean vestibulum condimentum lectus, eu tincidunt magna dictum quis."
      };
    }
  }
}