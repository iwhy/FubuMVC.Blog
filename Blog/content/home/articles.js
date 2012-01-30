define(['util/underscore', 'util/jquery', 'util/showdown'], function (_, $, sd) {
  var converter = sd.converter(),
    renderArticles = function (articles) {
      _.each(articles, function (article) {
        var $article = $('#article'),
            $container = $('div > section'),
            html;

        article.body = sd.makeHtml(article.body);
        $article.tmpl(article).appendTo($container);

      });
    };

  $.ajax({
    url: 'article/getall',
    dataType: 'json',
    success: renderArticles
  });
});