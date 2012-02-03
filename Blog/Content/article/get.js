require(['util/underscore', 'util/jquery', 'util/showdown', 'util/amplify'], function (_, $, sd, amplify) {
  var $article = $('article'),
      $articletemplate = $('#article-full'),
      renderArticle = function (article) {
        article.body = sd.makeHtml(article.body);
        $articletemplate.tmpl(article).appendTo($article);

      };

  $('').click(function () {
    amplify.publish('getCommentsForArticle', { articleIdentifier: article.identifier } );
  });

  $.ajax({
    url: 'article/get',
    dataType: 'json',
    success: renderArticle
  });
});