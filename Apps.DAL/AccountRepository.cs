
using Apps.IDAL;
using Apps.Models;
/**
* 命名空间: Apps.DAL
* 功 能： N/A
* 类 名： AccountRepository
* 创建时间： 2016/12/26 22:27:03 
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
    public class AccountRepository : IAccountRepository, IDisposable
    {
        public SysUser Login(string username, string pwd)
        {
            using (DBContainer db = new DBContainer())
            {
                SysUser user = db.SysUser.SingleOrDefault(a => a.UserName == username && a.Password == pwd);
                return user;
            }
        }
        public void Dispose()
        {

        }
    }
}
