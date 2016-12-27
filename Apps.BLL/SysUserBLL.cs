
using Apps.IBLL;
using Apps.IDAL;
using Apps.Models.Sys;
using Microsoft.Practices.Unity;
/**
* 命名空间: Apps.BLL
* 功 能： N/A
* 类 名： SysUserBLL
* 创建时间： 2016/12/27 21:35:18 
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
    public class SysUserBLL : BaseBLL, ISysUserBLL, IDisposable
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
    }
}
