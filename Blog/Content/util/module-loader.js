define(['util/jquery', 'util/js-loader'], function ($, jL) {
  var loader = {}, attr = 'data-module', module;

  loader.load = function (){
    $('['+attr+']').each(function() {
      module = $(this);
      $.ajax({
        url: module.attr(attr),
        success: function(moduleHtml) {
          module.html(jL.load(moduleHtml));
        }
      });
    });
  };

  return loader;
});