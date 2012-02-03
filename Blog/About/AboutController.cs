using FubuMVC.Core;

namespace Blog.About
{
  public class AboutController
  {
      [UrlPattern("contact")]
      public ContactPageViewModel Contact()
      {
          return new ContactPageViewModel();
      }

      [UrlPattern("author")]
      public AuthorPageViewModel Author()
      {
          return new AuthorPageViewModel();
      }
  }
}
