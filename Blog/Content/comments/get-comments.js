require(['util/underscore', 'util/jquery'], function (_, $) {
  var renderComments = function (comments) {
    _.each(comments, function (comment) {
      //render comment here.
    });
  };
  $('#load-comments').click(function() {
    $.ajax({
      url: 'comments/get',
      dataType: 'json',
      success: renderComments
    });
  });
});