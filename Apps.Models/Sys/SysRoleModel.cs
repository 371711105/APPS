/**
* 命名空间: Apps.Models.Sys
* 功 能： N/A
* 类 名： SysRoleModel
* 创建时间： 2016/12/30 18:48:44 
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
    public class SysRoleModel
    {
        public string Id { get; set; }

        [Display(Name = "角色名称")]
        public string Name { get; set; }

        [Display(Name = "说明")]
        public string Description { get; set; }
        [Display(Name = "创建时间")]
        public DateTime CreateTime { get; set; }
        [Display(Name = "创建人")]
        public string CreatePerson { get; set; }
        [Display(Name = "拥有的用户")]
        public string UserName { get; set; }//拥有的用户

        public string Flag { get; set; }//用户分配角色
    }
}
