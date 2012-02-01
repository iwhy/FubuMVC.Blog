using System.Collections.Generic;

namespace Blog.Comments
{
  public class CommentController
  {
    public dynamic GetCommentsQuery(RetrieveCommentForArticleInputModel inputModel)
    {
      return new List<CommentViewModel>();
    }
  }
}