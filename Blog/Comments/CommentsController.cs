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
      return new List<CommentViewModel>();
    }
  }
}