$('.btnChangeStatus').on('click', function () {
    var self = this;
    var id = $(this).val();
    var url = '/Api/UsersApi/ChangeStatus' + '?id=' + id;

    var request = $.ajax({
        url: url,
        type: "PUT",
        contentType: 'application/json',
        success: function (newStatus) {
            $(self).parent().find('span').text('Status: ' + newStatus);
        }
    });
});

$('.btnDelete').on('click', function () {
    var self = this;
    var id = $(this).val();
    var url = '/Api/UsersApi/DeleteUser' + '?id=' + id;

    var request = $.ajax({
        url: url,
        type: "DELETE",
        contentType: 'application/json',
        success: function () {
            $(self).parent().parent().fadeOut(1000);
        }
    });
});