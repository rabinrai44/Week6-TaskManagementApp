$(document).ready(function () {
    // ajax request given url and result give back and put into table
    $.ajax({
        url: '/TaskLists/BuildTaskTable',
        success: function (result) {
            $('#tableDiv').html(result);
        }
    });
});