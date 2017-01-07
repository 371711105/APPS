
using Apps.Common;
using Apps.Models;
using Apps.Models.Sys;
/**
* 命名空间: Apps.IBLL
* 功 能： N/A
* 类 名： ISysRoleBLL
* 创建时间： 2016/12/30 18:47:38 
* 创建人：小强
* 电子邮箱：371711105@qq.com
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.IBLL
{
    public interface ISysRoleBLL
    {
        List<SysRoleModel> GetList(ref GridPager pager, string queryStr);
        bool Create(ref ValidationErrors errors, SysRoleModel model);
        bool Delete(ref ValidationErrors errors, string id);
        bool Edit(ref ValidationErrors errors, SysRoleModel model);
        SysRoleModel GetById(string id);
        bool IsExist(string id);
        string GetRefSysUser(string roleId);
        IQueryable<P_Sys_GetUserByRoleId_Result> GetUserByRoleId(ref GridPager pager, string roleId);
        bool UpdateSysRoleSysUser(string roleId, string[] userIds);
    }
}
