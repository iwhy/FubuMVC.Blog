using System;

namespace Blog.Article
{
  public class ArticleViewModel
  {
    public string Author { get; set; }
    public DateTimeOffset PublishedDate { get; set; }
    public string Title { get; set; }
    public string Uri { get; set; }
    private string _body;

    public string Body
    {
      get { return _body.Replace(ArticleConstants.More, string.Empty); }
      set { _body = value; }
    }

    public string PublishedDateString
    {
      get { return PublishedDate.ToString("MMMM dd, yyyy"); }
    }

  }
}