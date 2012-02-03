require(['util/underscore', 'util/jquery'], function (_, $) {
  var $commenttemplate = $('#comment-full'),
    $comments = $('.comments'),
    renderComments = function (comments) {
        console.log('load');
      $comments.html('');
      _.each(comments, function (comment) {
        $commenttemplate.tmpl(comment).appendTo($comments);
      });
    };

  $('#load-comments').click(function() {
    $.ajax({
      url: 'comments/get',
      dataType: 'json',
      success: renderComments
    });
    return false;
  });
});