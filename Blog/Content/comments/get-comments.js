require(['util/underscore', 'util/jquery'], function (_, $) {
  var $commenttemplate = $('#comment-full'),
      $commentsLink = $('#load-comments'),
      $comments = $('.comments'),
      hash = location.hash,
      renderComments = function (comments) {
        $comments.html('');
        _.each(comments, function (comment) {
          $commenttemplate.tmpl(comment).appendTo($comments);
        });
      };

  $commentsLink.click(function() {
    $.ajax({
      url: 'comments/get',
      dataType: 'json',
      success: renderComments
    });
    return false;
  });

  if(hash && hash === '#comments') {
   $commentsLink.click();
  }

});