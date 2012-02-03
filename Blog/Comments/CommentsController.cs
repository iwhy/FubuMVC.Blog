using System;
using System.Collections.Generic;
using FubuMVC.Core;

namespace Blog.Comments
{
  public class CommentsController
  {
    [UrlPattern("comments/{Uri}")]
    public CommentsPageViewModel Index(CommentsPageInputModel inputModel)
    {
      return new CommentsPageViewModel{Uri = inputModel.Uri};
    }

    public dynamic GetQuery(RetrieveCommentForArticleInputModel inputModel)
    {
      return new List<CommentViewModel>
      {
        new CommentViewModel
        {
          Author = "Bob Duck",
          PublishedDate = DateTime.Now.AddHours(-5),
          Body = "Vivamus sodales venenatis neque ut pretium. Nam aliquam libero ac tellus malesuada quis porttitor nisl vehicula. Maecenas quis nunc lorem."
        },
        new CommentViewModel
        {
          Author = "Jane Doe",
          PublishedDate = DateTime.Now,
          Body = "Vivamus sodales venenatis neque ut pretium. Nam aliquam libero ac tellus malesuada quis porttitor nisl vehicula. Maecenas quis nunc lorem."
        },
        new CommentViewModel
        {
          Author = "Kong Door",
          PublishedDate = DateTime.Now.AddHours(9),
          Body = "Sodales neque ut pretium. Nam ac tellus malesuada quis nisl vehicula. Maecenas quis nunc."
        }
      };
    }
  }
}