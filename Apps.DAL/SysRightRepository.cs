
using Apps.IDAL;
using Apps.Models;
using Apps.Models.Sys;
/**
* 命名空间: Apps.DAL
* 功 能： N/A
* 类 名： SysRightRepository
* 创建时间： 2016/12/27 21:29:48 
* 创建人：小强
* 电子邮箱：371711105@qq.com
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.DAL
{
    public class SysRightRepository : ISysRightRepository, IDisposable
    {

        /// <summary>
        /// 取角色模块的操作权限，用于权限控制
        /// </summary>
        /// <param name="accountid">acount Id</param>
        /// <param name="controller">url</param>
        /// <returns></returns>
        public List<PermModel> GetPermission(string accountid, string controller)
        {

            using (DBContainer db = new DBContainer())
            {
                List<PermModel> rights = (from r in db.P_Sys_GetRightOperate(accountid, controller)
                                          select new PermModel
                                          {
                                              KeyCode = r.KeyCode,
                                              IsValid = r.IsValid
                                          }).ToList();
                return rights;
            }
        }
        public void Dispose()
        {

        }
    }
}
