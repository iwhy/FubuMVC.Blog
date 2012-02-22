using System;
using System.Linq;

namespace Blog.Article.Summaries
{
  public class ArticleSummaryViewModel
  {
    public string Author { get; set; }
    public DateTimeOffset PublishedDate { get; set; }
    public string Title { get; set; }
    public string Uri { get; set; }
    private string _summary;

    public string Summary
    {
      get { return _summary; }
      set
      {
        var text = value.Split(new []{ ArticleConstants.More }, StringSplitOptions.None);
        
        _summary = text.First();
      }
    }

    public string PublishedDateString
    {
      get { return PublishedDate.ToString("MMMM dd, yyyy"); }
    }

  }
}