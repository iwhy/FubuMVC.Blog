define(['util/jquery', 'util/js-loader'], function ($, jL) {
  var loader = {},
      attr = 'data-module';

  loader.load = function (){
    $('['+attr+']').each(function() {
      var module = $(this);
      $.ajax({
        url: module.attr(attr),
        success: function(moduleHtml) {
          module.html(moduleHtml);
          jL.load(moduleHtml);
        }
      });
    });
  };

  return loader;
});