require(['util/jquery','util/showdown'], function ($,sd) {
  var article = $('section', 'article'),
      html = article.text().trim(),
      md = sd.makeHtml(html);
  article.html(md);
  prettyPrint();
});