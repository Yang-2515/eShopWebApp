function Login() {
    var data = $("#loginForm").serialize();
    console.log(data);
    $.ajax({
        type: 'POST',
        url: '/Login/checkLogin',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8', // when we use .serialize() this generates the data in query string format. this needs the default contentType (default content type is: contentType: 'application/x-www-form-urlencoded; charset=UTF-8') so it is optional, you can remove it
        data: data,
        success: function (result) {
        },
        error: function () {
            alert('Failed to receive the Data');
            console.log('Failed ');
        }
    })
}
