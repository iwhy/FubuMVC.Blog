using PetaPoco;

namespace Blog.Comments.Count
{
  public class GetHandler
  {
    private readonly IDatabase _db;

    public GetHandler(IDatabase db)
    {
      _db = db;
    }

    public dynamic Execute(CommentsCountInputModel inputModel)
    {
      return _db.Query<int>("select count(*) from V_Comment where ArticleUri = @0", inputModel.ArticleUri);
    }
  }
}