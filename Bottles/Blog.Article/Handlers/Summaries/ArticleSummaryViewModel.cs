using System;
using System.Linq;
using Blog.Core;

namespace Blog.Articles.Summaries
{
    public class ArticleSummaryViewModel
    {
        public string Id { get; set; }
        public string Author { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Title { get; set; }
        public string Uri { get { return Id.Replace("article/", string.Empty); } }
        public string Body { get; set; }

        public string Summary
        {
            get
            {
                var text = Body.Split(new[] { ArticleConstants.More }, StringSplitOptions.None);
                return text.First();
            }
        }

        public string PublishedDateString
        {
            get { return PublishedDate.ToString("MMMM dd, yyyy"); }
        }

    }
}