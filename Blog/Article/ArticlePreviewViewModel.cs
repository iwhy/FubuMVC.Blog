using System;
using System.Linq;

namespace Blog.Article
{
  public class ArticlePreviewViewModel
  {
    private const string more = "<!--more-->";

    public string Author { get; set; }
    public DateTime PublishedDate { get; set; }
    public string Title { get; set; }
    public string Uri { get; set; }
    private string _preview;

    public string Preview
    {
      get { return _preview; }
      set
      {
        var text = value.Split(new []{more}, StringSplitOptions.None);
        
        _preview = text.First();
      }
    }

    public string PublishedDateString
    {
      get { return PublishedDate.ToString("MMMM dd, yyyy"); }
    }

  }
}