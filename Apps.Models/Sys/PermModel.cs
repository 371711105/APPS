/**
* 命名空间: Apps.Models
* 功 能： N/A
* 类 名： PermModel
* 创建时间： 2016/12/27 21:26:42 
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
    public class PermModel
    {
        public string KeyCode { get; set; }//操作码
        public bool IsValid { get; set; }//是否验证
    }
}
