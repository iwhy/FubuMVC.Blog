using System;

namespace Blog.Article
{
  public class ArticleViewModel : IArticle
  {
    public string Author { get; set; }
    public DateTime PublishedDate { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public Guid Identifier { get; set; }

    public string PublishedDateString
    {
      get { return PublishedDate.ToString("MMMM dd, yyyy"); }
    }

  }
}