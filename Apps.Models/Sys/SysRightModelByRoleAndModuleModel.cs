/**
* 命名空间: Apps.Models
* 功 能： N/A
* 类 名： SysRightModelByRoleAndModuleModel
* 创建时间： 2016/12/31 15:22:53 
* 创建人：小强
* 电子邮箱：371711105@qq.com
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Models.Sys
{
    public class SysRightModelByRoleAndModuleModel
    {
        public string Ids { get; set; }// RightId+ KeyCode ids
        public string Name { get; set; }
        public string KeyCode { get; set; }
        public bool? IsValid { get; set; }
        public string RightId { get; set; }
    }
}
