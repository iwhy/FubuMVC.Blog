using System;
using System.Linq;

namespace Blog.Article
{
  public class ArticlePreviewViewModel : IArticle
  {
    private const string more = "<!--more-->";

    public string Author { get; set; }
    public DateTime PublishedDate { get; set; }
    public string Title { get; set; }
    public string Uri { get; set; }
    private string _body;

    public string Body
    {
      get { return _body; }
      set
      {
        var text = value.Split(new []{more}, StringSplitOptions.None);
        
        _body = text.First();
      }
    }

    public Guid Identifier { get; set; }

    public string PublishedDateString
    {
      get { return PublishedDate.ToString("MMMM dd, yyyy"); }
    }

  }
}