$(function () {
    var $formAdd = $("#formAdd");
    $formAdd.validate({
        //errorPlacement: function (error, element) {
        //    if (element.attr("id") == "Code") {
        //        error.appendTo($(".code-error"));
        //    }
        //    else {
        //        error.appendTo(element.parent());
        //    }
        //},
        debug: true,
        rules: {
            UserName: {
                required: true,
                remote: {
                    url: "/SysUser/IsExisted",     //后台处理程序
                    type: "post",               //数据发送方式
                    dataType: "json"           //接受数据格式                       
                }
            },
            Password: {
                required: true,
                minlength: 6,
                maxlength: 16
            },
            TrueName: {
                required: true
            },
            MobileNumber: {
                required: true,
                isMobileNumber: true
            },
            EmailAddress: {
                required: true,
                email: true
            },
            State: {
                required: false
            }
        },
        messages: {
            UserName: {
                remote: "该用户名已注册"
            }
        },
        submitHandler: function (form) {
            //console.log($(form).serialize());
            addUser($(form).serialize());
        }
    });
    function addUser(postData) {
        $.ajax({
            url: "/SysUser/Create",
            type: "Post",
            data: postData,
            dataType: "json",
            success: function (data) {
                if (data.type == 1) {
                    layer.confirm(data.message,
                         {
                             btn: ['确定'] //按钮
                         },
                        function () {
                            window.location.reload();
                        });
                }
                else {
                    layer.alert(data.message);
                }
            }
        });
    };
});