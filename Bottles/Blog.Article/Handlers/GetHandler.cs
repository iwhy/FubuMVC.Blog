using FubuMVC.Core;
using PetaPoco;

namespace Blog.Article
{
  public class GetHandler
  {
    private readonly IDatabase _db;

    public GetHandler(IDatabase db)
    {
      _db = db;
    }

    [UrlPattern("{Uri}")]
    public ArticleViewModel Execute(ArticleInputModel inputModel)
    {
      return _db.Single<ArticleViewModel>("select * from V_Article");
    }
  }
}