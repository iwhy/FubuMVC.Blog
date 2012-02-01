define(['util/underscore', 'util/jquery', 'util/showdown'], function (_, $, sd) {
  var converter = sd.converter(),
      $article = $('article'),
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