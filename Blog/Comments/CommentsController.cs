using System.Collections.Generic;
using FubuMVC.Core;

namespace Blog.Comments
{
  public class CommentsController
  {
    [UrlPattern("article-comments")]
    public CommentsPageViewModel Index()
    {
      return new CommentsPageViewModel();
    }

    public dynamic GetQuery(RetrieveCommentForArticleInputModel inputModel)
    {
      return new List<CommentViewModel>();
    }
  }
}