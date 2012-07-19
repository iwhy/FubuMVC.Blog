﻿require(['util/module-loader', 'util/jquery'], function (mL, $) {

  $.ajaxSetup({
    statusCode: {
      500: function (error) {
        if(window.location.pathname === '/') {
          $('.bootstrap-error').show();
        }
      } 
    }
  });
  mL.load();
});