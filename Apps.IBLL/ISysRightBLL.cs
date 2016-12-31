/**
* 命名空间: Apps.BLL
* 功 能： N/A
* 类 名： ISysRightBLL
* 创建时间： 2016/12/31 15:26:36 
* 创建人：小强
* 电子邮箱：371711105@qq.com
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apps.Models.Sys;
using Apps.Models;

namespace Apps.BLL
{
    public interface ISysRightBLL
    {
        bool UpdateRight(SysRightOperateModel model);
        List<P_Sys_GetRightByRoleAndModule_Result> GetRightByRoleAndModule(string roleId, string moduleId);
    }
}
