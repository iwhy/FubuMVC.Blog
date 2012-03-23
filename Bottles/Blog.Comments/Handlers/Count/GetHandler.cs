using System.Linq;
using Raven.Client;
using Raven.Client.Linq;

namespace Blog.Comments.Count
{
  public class GetHandler
  {
      private readonly IDocumentSession _session;

      public GetHandler(IDocumentSession session)
    {
        _session = session;
    }

    public dynamic Execute(CommentsCountInputModel inputModel)
    {
        RavenQueryStatistics stats;
        _session.Query<CommentViewModel>()
            .Where(x => x.ArticleUri == inputModel.ArticleUri)
            .Statistics(out stats).ToArray();

        return stats.TotalResults;
    }
  }
}