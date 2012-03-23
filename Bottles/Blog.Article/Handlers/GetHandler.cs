using FubuMVC.Core;
using Raven.Client;

namespace Blog.Article
{
  public class GetHandler
  {
      private readonly IDocumentSession _session;

    public GetHandler(IDocumentSession session)
    {
        _session = session;
    }

    [UrlPattern("{Uri}")]
    public ArticleViewModel Execute(ArticleInputModel inputModel)
    {
        return _session.Load<ArticleViewModel>(string.Format("article/{0}",inputModel.Uri));
    }
  }
}