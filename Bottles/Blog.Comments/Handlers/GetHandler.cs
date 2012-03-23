using FubuMVC.Core;
using Raven.Client;
using Raven.Client.Linq;

namespace Blog.Comments
{
  public class GetHandler
  {
    private readonly IDocumentSession _session;

    public GetHandler(IDocumentSession session)
    {
        _session = session;
    }

    [UrlPattern("comments/{Uri}")]
    public CommentsViewModel Execute(CommentsInputModel inputModel)
    {
      return new CommentsViewModel
      {
        Comments = _session.Query<CommentViewModel>()
            .Where(x => x.ArticleUri.Equals(inputModel.Uri))
            .OrderByDescending(x => x.PublishedDate)
      };
    }
  }
}