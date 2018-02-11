$(document).ready(function () {

    // BEGIN: SHOW COUNTDOWN WHEN USER TYPES ON FORM FIELDS
    $('input,textarea').keyup(function () {
        var maxLength = $(this).attr("maxlength");
        var length = $(this).val().length;
        length = maxLength - length;
        $(this).siblings(".countdown").text(length + " characters remaining");
    });
    // END: SHOW COUNTDOWN WHEN USER TYPES ON FORM FIELDS

    // BEGIN: HIDE COUNTDOWN WHEN USER LEAVES FORM FIELD
    $('input,textarea').change(function () {
        $(this).siblings(".countdown").text("");
    });
    // END: HIDE COUNTDOWN WHEN USER LEAVES FORM FIELD


});