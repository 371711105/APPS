
using Apps.IDAL;
using Apps.Models;
using Apps.Models.Sys;
using Microsoft.Practices.Unity;
/**
* 命名空间: Apps.BLL
* 功 能： N/A
* 类 名： SysRightBLL
* 创建时间： 2016/12/31 15:32:43 
* 创建人：小强
* 电子邮箱：371711105@qq.com
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.BLL
{
    public class SysRightBLL : ISysRightBLL, IDisposable
    {
        [Dependency]
        public ISysRightRepository sysRightRepository { get; set; }
        public List<PermModel> GetPermission(string accountid, string controller)
        {
            return sysRightRepository.GetPermission(accountid, controller);
        }
        public void Dispose()
        {

        }
        public bool UpdateRight(SysRightOperateModel model)
        {
            try
            {
                SysRightOperate entity = new SysRightOperate();
                if (model == null)
                {
                    return false;
                }
                entity.Id = model.Id;
                entity.IsValid = model.IsValid;
                entity.KeyCode = model.KeyCode;
                entity.RightId = model.RightId;

                if (sysRightRepository.UpdateRight(entity) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<P_Sys_GetRightByRoleAndModule_Result> GetRightByRoleAndModule(string roleId, string moduleId)
        {
            return sysRightRepository.GetRightByRoleAndModule(roleId, moduleId);
        }
    }
}
