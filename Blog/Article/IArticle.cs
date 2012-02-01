using System;

namespace Blog.Article
{
  public interface IArticle
  {
    Guid Identifier { get; set; }
    string Author { get; set; }
    DateTime PublishedDate { get; set; }
    string Title { get; set; }
    string Uri { get; set; }
    string Body { get; set; }
  }
}