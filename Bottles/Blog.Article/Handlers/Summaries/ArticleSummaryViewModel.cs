using System;
using System.Linq;

namespace Blog.Article.Summaries
{
  public class ArticleSummaryViewModel
  {
    private const string more = "<!--more-->";

    public string Author { get; set; }
    public DateTime PublishedDate { get; set; }
    public string Title { get; set; }
    public string Uri { get; set; }
    private string _summary;

    public string Summary
    {
      get { return _summary; }
      set
      {
        var text = value.Split(new []{more}, StringSplitOptions.None);
        
        _summary = text.First();
      }
    }

    public string PublishedDateString
    {
      get { return PublishedDate.ToString("MMMM dd, yyyy"); }
    }

  }
}