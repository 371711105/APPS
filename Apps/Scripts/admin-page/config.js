; (function (w) {
    'use strict';
    var config = {};

    //判断是否微信打开页面
    config.isWeixin = function () {
        var ua = navigator.userAgent.toLowerCase();
        var wx = /micromessenger/;
        if (wx.test(ua)) {
            return true;
        }
        return false;
    };

    //验证是否为空
    config.isNull = function isNull(value) {
        if (value == null || value == undefined || value.length == 0)
            return true;
        else
            return false;
    }

    //验证是否为日期格式
    config.isDate = function isDate(value) {
        if (config.isNull(value))
            return false;
        var reg = /^(\d{1,4})(-|\/)(\d{1,2})\2(\d{1,2})$/;
        var r = value.match(reg);
        if (r != null)
            return true;
        else
            return false;
    }

    //判断是否为email
    config.isEmail = function isEmail(value) {
        if (config.isNull(value))
            return false;
        var reg = /^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/;
        if (reg.test(value))
            return true;
        else
            return false;
    }

    //判断是否为手机号
    config.isMobileNumber = function isMobileNumber(value) {
        if (config.isNull(value))
            return false;
        var length = value.length;
        var reg = /^1[3|5|7|8][0-9]{9}$/;
        if (length == 11 && reg.test(value))
            return true;
        else
            return false;
    }

    //判断是否为银行卡
    config.isBankCard = function isBankCard(value) {
        if (config.isNull(value))
            return false;
        var reg = /^\d{8,}$/;
        if (reg.test(value))
            return true;
        else
            return false;
    }

    //判断是否是浮点数字
    config.checkRate = function checkRate(value) {
        if (value == "" || value == null)
            return false;
        var reg = /^[0-9]+.?[0-9]*$/;   //判断字符串是否为数字
        if (reg.test(value))
            return true;
        else
            return false;
    }

    //判断是否纯数字
    config.isdigital = function (value) {
        if (config.isNull(value))
            return false;
        var reg = /^[0-9]*$/;
        if (reg.test(value))
            return true;
        else
            return false;
    }

    //判断是否有字母加数字
    config.isAccountContainNumAndCase = function (value) {
        if (config.isNull(value))
            return false;
        var reg = /^[a-zA-Z][a-zA-Z0-9]+$/;
        if (reg.test(value))
            return true;
        else
            return false;
    }

    //判断确认密码
    config.confirmPassword = function confirmPassword(value1, value2) {
        if (value1 != value2)
            return false;
        else return true;
    }

    //判断是否是正整数
    config.isNumber = function isNumber(value) {
        if (config.isNull(value))
            return false;
        var reg = new RegExp("^[0-9]*$");
        if (reg.test(value))
            return true;
        else
            return false;
    }

    //只能中英文和数字  ^[a-zA-Z0-9\u4E00-\u9FA5]+$
    config.isLimitString = function isLimitString(value) {
        if (config.isNull(value))
            return false;
        var reg = /^[a-zA-Z0-9\u4E00-\u9FA5]+$/;
        if (reg.test(value))
            return true;
        else
            return false;
    }

    //星号隐藏中间值（卡号、手机、身份证）
    config.replaceAsterisk = function replaceAsterisk(str, frontLen, endLen) {
        var len = str.length - frontLen - endLen;
        var asterisk = '';
        for (var i = 0; i < len; i++) {
            asterisk += '*';
        }
        return str.substr(0, frontLen) + asterisk + str.substr(str.length - endLen);
    }

    //从后面截取
    config.cutOutStr = function cutOutStr(str, Len) {
        var str = str;
        return str.substr(str.length - Len);
    }

    //金额分隔，
    config.fmoney = function fmoney(s, n) {
        //debugger;
        //修改了部分代码适配整数的时候也可以分隔；
        n = n > 0 && n <= 20 ? n : 0;
        s = parseFloat((s + "").replace(/[^\d\.-]/g, "")).toFixed(n) + "";
        var l = s.split(".")[0].split("").reverse(),
        r = s.split(".")[1] || "",
        t = "";
        for (var i = 0; i < l.length; i++) {
            t += l[i] + ((i + 1) % 3 == 0 && (i + 1) != l.length ? "," : "");
        }
        if (r) {
            r = "." + r;
        };
        return t.split("").reverse().join("") + r;
    }

    //日期转成指定格式的string
    config.dateToString = function dateToString(date, fmt) {
        var date = new Date(date);
        if (date) {
            var o = {
                "M+": date.getMonth() + 1,                 //月份   
                "d+": date.getDate(),                    //日   
                "h+": date.getHours(),                   //小时   
                "m+": date.getMinutes(),                 //分   
                "s+": date.getSeconds(),                 //秒   
                "q+": Math.floor((date.getMonth() + 3) / 3), //季度   
                "S": date.getMilliseconds()             //毫秒   
            };
            if (!fmt)
                fmt = "yyyy-MM-dd";
            if (/(y+)/.test(fmt))
                fmt = fmt.replace(RegExp.$1, (date.getFullYear() + "").substr(4 - RegExp.$1.length));
            for (var k in o)
                if (new RegExp("(" + k + ")").test(fmt))
                    fmt = fmt.replace(RegExp.$1, (RegExp.$1.length == 1) ? (o[k]) : (("00" + o[k]).substr(("" + o[k]).length)));
            return fmt;
        }
    }

    //date转成年月日 时分秒
    config.dateToStringDetail = function (date) {
        return config.dateToString(date, "yyyy-MM-dd hh:mm:ss");
    };

    //获取url之后的参数
    config.getFragment = function getFragment() {
        if (window.location.search.indexOf("?") === 0) {
            return parseQueryString(window.location.search.substr(1));
        }
        else {
            return {};
        }
        function parseQueryString(queryString) {
            var data = {},
                pairs, pair, separatorIndex, escapedKey, escapedValue, key, value;

            if (queryString === null) {
                return data;
            }

            pairs = queryString.split("&");

            for (var i = 0; i < pairs.length; i++) {
                pair = pairs[i];
                separatorIndex = pair.indexOf("=");

                if (separatorIndex === -1) {
                    escapedKey = pair;
                    escapedValue = null;
                } else {
                    escapedKey = pair.substr(0, separatorIndex);
                    escapedValue = pair.substr(separatorIndex + 1);
                }

                key = decodeURIComponent(escapedKey);
                value = decodeURIComponent(escapedValue);

                data[key] = value;
            }

            return data;
        }
    };

    //创建cookie
    config.setCookie = function setCookie(cookieName, value, expiredays) {
        expiredays = expiredays ? expiredays : 365;
        var exdate = new Date();
        exdate.setDate(exdate.getDate() + expiredays);
        document.cookie = cookieName + "=" + escape(value) +
        ((expiredays == null) ? "" : ";expires=" + exdate.toGMTString());
    }

    //获取cookie
    config.getCookie = function getCookie(cookieName) {
        var cStart, cEnd;
        if (document.cookie.length > 0) {
            cStart = document.cookie.indexOf(cookieName + "=");
            if (cStart != -1) {
                cStart = cStart + cookieName.length + 1;
                cEnd = document.cookie.indexOf(";", cStart);
                if (cEnd == -1) cEnd = document.cookie.length;
                return unescape(document.cookie.substring(cStart, cEnd));
            }
        }
        return ""
    };
    //删除cookie中指定变量函数    
    config.deleteCookie = function delCookie(name, path) {
        //debugger;
        //如果path不指定，则会出现无法清除cookie的问题；
        path = path ? path : "/views/user";
        var exp = new Date();
        exp.setTime(exp.getTime() - 1);
        var cval = config.getCookie(name);
        if (cval != null)
            document.cookie = name + "=" + "" + ";expires=" + exp.toGMTString() + ";path=" + path;
    }
    //根据http status定制错误提示信息
    config.getErrorMessage = function (xhr) {
        switch (xhr.status) {
            case 0:
                return "网络不给力";
                break;
            case 408:
                return "请求超时";
                break;
            case 401:
                return "请登入";
                break;
            default:
                return "请求错误";
                break;
        };
    }

    //判断浏览器终端
    config.browser = {
        versions: function () {
            var u = navigator.userAgent, app = navigator.appVersion;
            return { //移动终端浏览器版本信息 
                ios: !!u.match(/\(i[^;]+;( U;)? CPU.+Mac OS X/), //ios终端 
                android: u.indexOf('Android') > -1 || u.indexOf('Linux') > -1, //android终端或uc浏览器 
                iPhone: u.indexOf('iPhone') > -1, //是否为iPhone或者QQHD浏览器 
                iPad: u.indexOf('iPad') > -1, //是否iPad 
            };
        }(),
    }

    w.config = config;
})(window);