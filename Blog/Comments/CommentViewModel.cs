﻿using System;

namespace Blog.Comments
{
  public class CommentViewModel : IComment
  {
    public string Author { get; set; }
    public DateTime PublishedDate { get; set; }
    public string Body { get; set; }

    public string PublishedDateString
    {
      get { return PublishedDate.ToString("MMMM dd, yyyy (hh:mm)"); }
    }

  }
}