define(['util/jquery'], function ($) {
  var loader = {}, scripts, source;

  loader.load = function (html) {
      scripts = $(html).filter('script');
      scripts.each(function () {
        source = $(this).attr('src');
        if(source) {
          require([source]);
        }
      });
  };

  return loader;
});