
using Apps.Models;
/**
* 命名空间: Apps.IDAL
* 功 能： N/A
* 类 名： ISysModuleRepository
* 创建时间： 2016/12/27 22:23:35 
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
    public interface ISysModuleRepository
    {
        IQueryable<SysModule> GetList(DBContainer db);
        IQueryable<SysModule> GetModuleBySystem(DBContainer db, string parentId);
        int Create(SysModule entity);
        void Delete(DBContainer db, string id);
        int Edit(SysModule entity);
        SysModule GetById(string id);
        bool IsExist(string id);
    }
}
