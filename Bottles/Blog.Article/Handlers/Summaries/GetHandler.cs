using System.Linq;
using Raven.Client;

namespace Blog.Article.Summaries
{
    public class GetHandler
    {
        private readonly IDocumentSession _session;

        public GetHandler(IDocumentSession session)
        {
            _session = session;
        }

        public ArticleSummariesViewModel Execute()
        {
            var articles = _session.Query<ArticleViewModel>()
                //.OrderByDescending(x => x.PublishedDate)
                .Take(10).ToList();

            return new ArticleSummariesViewModel
            {
                Summaries = articles
            };
        }
    }
}