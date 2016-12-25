/**
* 命名空间: Apps.Models.sys
* 功 能： N/A
* 类 名： SysSampleModel
* 创建时间： 2016/12/21 17:15:52 
* 创建人：小强
* 电子邮箱：371711105@qq.com
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
namespace Apps.Models.Sys
{
    public class SysSampleModel
    {
        [Display(Name = "ID")]
        public string Id { get; set; }


        [Display(Name = "名称")]
        public string Name { get; set; }


        [Display(Name = "年龄")]
        [Range(0, 10000)]
        public int? Age { get; set; }

        [Display(Name = "生日")]
        public DateTime? Bir { get; set; }

        [Display(Name = "照片")]
        public string Photo { get; set; }


        [Display(Name = "简介")]
        public string Note { get; set; }

        [Display(Name = "创建时间")]
        public DateTime? CreateTime { get; set; }

    }
}