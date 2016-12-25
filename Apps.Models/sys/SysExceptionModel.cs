/**
* 命名空间: Apps.Models.sys
* 功 能： N/A
* 类 名： SysExceptionModel
* 创建时间： 2016/12/25 15:37:16 
* 创建人：小强
* 电子邮箱：371711105@qq.com
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Models.sys
{
    /// <summary>
    /// 异常处理类
    /// </summary>
    public class SysExceptionModel
    {

        [Display(Name = "ID")]
        public string Id { get; set; }

        [Display(Name = "帮助链接")]
        public string HelpLink { get; set; }

        [Display(Name = "错误信息")]
        public string Message { get; set; }

        [Display(Name = "来源")]
        public string Source { get; set; }

        [Display(Name = "堆栈")]
        public string StackTrace { get; set; }

        [Display(Name = "目标页")]
        public string TargetSite { get; set; }

        [Display(Name = "程序集")]
        public string Data { get; set; }

        [Display(Name = "发生时间")]
        public DateTime? CreateTime { get; set; }
    }
}
