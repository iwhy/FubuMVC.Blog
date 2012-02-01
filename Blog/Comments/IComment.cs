using System;

namespace Blog.Comments
{
  public interface IComment
  {
    string Author { get; set; }
    DateTime PublishedDate { get; set; }
    string Body { get; set; }
  }
}