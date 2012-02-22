using PetaPoco;

namespace Blog.Article.Summaries
{
  public class GetHandler
  {
    private readonly IDatabase _db;

    public GetHandler(IDatabase db)
    {
      _db = db;
    }

    public ArticleSummariesViewModel Execute()
    {
      return new ArticleSummariesViewModel
      {
        Summaries = _db.Query<ArticleSummaryViewModel>("select * from V_ArticleSummary")
      };
    }
  }
}