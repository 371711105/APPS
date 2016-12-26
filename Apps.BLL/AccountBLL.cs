
using Apps.IDAL;
using Apps.Models;
using Microsoft.Practices.Unity;
/**
* 命名空间: Apps.BLL
* 功 能： N/A
* 类 名： AccountBLL
* 创建时间： 2016/12/26 22:29:59 
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
    public class AccountBLL : BaseBLL, IAccountBLL
    {
        [Dependency]
        public IAccountRepository accountRepository { get; set; }
        public SysUser Login(string username, string pwd)
        {
            return accountRepository.Login(username, pwd);

        }
    }
}
