﻿define('login', ['jquery'], function ($) {
  if ($('#authorization').length > 0) {
    window.location = '/';
    return;
  }

  $('form').show();
  openid.init('OpenidIdentifier');
});