
using Apps.Models;
/**
* 命名空间: Apps.IDAL
* 功 能： N/A
* 类 名： ISysRoleRepository
* 创建时间： 2016/12/30 18:45:57 
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
    public interface ISysRoleRepository
    {

        IQueryable<SysRole> GetList(DBContainer db);
        int Create(SysRole entity);
        int Delete(string id);
        int Edit(SysRole entity);
        SysRole GetById(string id);
        bool IsExist(string id);
    }
}
