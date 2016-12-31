/**
* 命名空间: Apps.Models.Sys
* 功 能： N/A
* 类 名： SysRightOperateModel
* 创建时间： 2016/12/31 15:28:47 
* 创建人：小强
* 电子邮箱：371711105@qq.com
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Models.Sys
{
    public class SysRightOperateModel
    {
        [DisplayName("ID")]
        public string Id { get; set; }
        [DisplayName("权限ID")]
        public string RightId { get; set; }
        [DisplayName("权限值")]
        public string KeyCode { get; set; }
        [DisplayName("是否有效")]
        public bool IsValid { get; set; }
    }
}
