﻿require(['util/underscore', 'util/jquery', 'util/showdown'], function (_, $, sd) {
  var $articletemplate = $('#article-preview'),
      $container = $('div > section'),
      renderArticles = function (articles) {
        _.each(articles, function (article) {
          article.body = sd.makeHtml(article.body);
          $articletemplate.tmpl(article).appendTo($container);
        });
      };

  $.ajax({
    url: 'article/getall',
    dataType: 'json',
    success: renderArticles
  });
});