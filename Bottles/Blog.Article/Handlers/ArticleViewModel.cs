using System;
using Blog.Core;

namespace Blog.Articles
{
  public class ArticleViewModel
  {
    public string Id { get; set; }
    public string Author { get; set; }
    public DateTime PublishedDate { get; set; }
    public string Title { get; set; }
    public string Uri { get { return Id.Replace("article/", string.Empty); } }
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