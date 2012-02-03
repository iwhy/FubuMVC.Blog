require(['util/underscore', 'util/jquery', 'util/showdown', 'util/amplify'], function (_, $, sd, amplify) {
  var renderComments = function () {
  };
  $('#load-comments').click(function() {
   $.ajax({
     url: 'comments/get',
     data: data,
     success: renderComments
   });
  });
});