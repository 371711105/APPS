﻿/**
* 命名空间: Apps.Models.sys
* 功 能： N/A
* 类 名： SysLogModel
* 创建时间： 2016/12/25 12:40:39 
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
    public class SysLogModel
    {


        [Display(Name = "ID")]
        public string Id { get; set; }

        [Display(Name = "操作人")]
        public string Operator { get; set; }

        [Display(Name = "信息")]
        public string Message { get; set; }

        [Display(Name = "结果")]
        public string Result { get; set; }

        [Display(Name = "类型")]
        public string Type { get; set; }

        [Display(Name = "模块")]
        public string Module { get; set; }

        [Display(Name = "创建时间")]
        public DateTime? CreateTime { get; set; }
    }
}