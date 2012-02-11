require(['util/underscore', 'util/jquery', 'util/showdown'], function (_, $, sd) {
  var $article = $('article'),
      $articletemplate = $('#article-full'),
      renderArticle = function (article) {
        article.body = sd.makeHtml(article.body);
        $articletemplate.tmpl(article).appendTo($article);
      };

  $.ajax({
    url: 'article/get',
    dataType: 'json',
    success: renderArticle
  });
});