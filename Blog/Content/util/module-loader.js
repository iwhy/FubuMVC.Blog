define(['util/jquery'], function ($) {
  var loader = {},
      attr = 'data-module';

  loader.load = function (){
    $('['+attr+']').each(function() {
      var module = $(this);
      $.ajax({
        url: module.attr(attr),
        success: function(moduleHtml) {
          module.html(moduleHtml);
        }
      });
    });
  };

  return loader;
});