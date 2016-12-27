/**
* 命名空间: Apps.Models.Sys
* 功 能： N/A
* 类 名： SysModuleOperateModel
* 创建时间： 2016/12/27 22:42:54 
* 创建人：小强
* 电子邮箱：371711105@qq.com
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Models.Sys
{
    public class SysModuleOperateModel
    {
        [Display(Name = "ID")]
        public string Id { get; set; }
        [Display(Name = "操作名称")]
        public string Name { get; set; }
        [Display(Name = "操作码")]
        public string KeyCode { get; set; }
        [Display(Name = "所属模块")]
        public string ModuleId { get; set; }
        [Display(Name = "是否验证")]
        public bool IsValid { get; set; }
        [Required(ErrorMessage = "{0}必须填写")]
        [Display(Name = "排序号")]
        public int Sort { get; set; }
    }
}
