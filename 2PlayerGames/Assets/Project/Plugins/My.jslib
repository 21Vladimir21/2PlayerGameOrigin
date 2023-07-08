mergeInto(LibraryManager.library, {

  Helloo: function () {
    window.alert("Hello, world!");
  },

  HelloString: function (str) {
    window.alert(UTF8ToString(str));
  },

});