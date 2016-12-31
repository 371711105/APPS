
using Apps.Models;
using Apps.Models.Sys;
/**
* 命名空间: Apps.IDAL
* 功 能： N/A
* 类 名： ISysRightRepository
* 创建时间： 2016/12/27 21:29:04 
* 创建人：小强
* 电子邮箱：371711105@qq.com
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.IDAL
{
    public interface ISysRightRepository
    {
        List<PermModel> GetPermission(string accountid, string controller);
        //更新
        int UpdateRight(SysRightOperate model);
        //按选择的角色及模块加载模块的权限项
        List<P_Sys_GetRightByRoleAndModule_Result> GetRightByRoleAndModule(string roleId, string moduleId);
    }
}
