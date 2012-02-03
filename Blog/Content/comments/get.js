require(['util/underscore', 'util/jquery', 'util/showdown', 'util/amplify'], function (_, $, sd, amplify) {
  var renderComments = function () {

  };

  amplify.subscribe('getCommentsForArticle', function (data) {
    $.ajax({
      url: 'comments/get',
      data: data,
      success: renderComments
    });
  });
});