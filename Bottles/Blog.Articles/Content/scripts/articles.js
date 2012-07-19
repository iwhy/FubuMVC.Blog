require(['util/jquery', 'util/showdown', 'util/underscore'], function ($, sd, _) {
  var articles = $('section', 'article'),
      html;

  _.each(articles, function (article) {
    article = $(article);
    html = article.html().trim();
    article.html(sd.makeHtml(html));
  });
  prettyPrint();

});