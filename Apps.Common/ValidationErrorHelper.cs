/**
* 命名空间: Apps.Common
* 功 能： N/A
* 类 名： ValidationErrorHelper
* 创建时间： 2016/12/25 16:54:12 
* 创建人：小强
* 电子邮箱：371711105@qq.com
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Common
{
    public class ValidationError
    {
        public ValidationError() { }
        public string ErrorMessage { get; set; }

    }
    public class ValidationErrors : List<ValidationError>
    {
        /// <summary>
        /// 添加错误
        /// </summary>
        /// <param name="errorMessage">信息描述</param>
        public void Add(string errorMessage)
        {
            base.Add(new ValidationError { ErrorMessage = errorMessage });
        }
        /// <summary>
        /// 获取错误集合
        /// </summary>
        public string Error
        {
            get
            {
                string error = "";
                this.All(a =>
                {
                    error += a.ErrorMessage;
                    return true;
                });
                return error;
            }
        }
    }
}
