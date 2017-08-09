$(document).ready(function() {
  // $("#tempdisplay").hide();

  $("img").click(function() {
    var value = $(this).parent().children("input").val();
    $("#valueHolder").val(value);
    $("#tempPlayer").text(value);
    $("#tempdisplay").show();

  })

})
