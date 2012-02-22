using FubuMVC.Core;
using PetaPoco;

namespace Blog.Comments
{
  public class GetHandler
  {
    private readonly IDatabase _db;

    public GetHandler(IDatabase db)
    {
      _db = db;
    }

    [UrlPattern("comments/{Uri}")]
    public CommentsViewModel Execute(CommentsInputModel inputModel)
    {
      return new CommentsViewModel
      {
        Comments = _db.Query<CommentViewModel>("select * from V_Comment where ArticleUri = @0", inputModel.Uri)
      };
    }
  }
}