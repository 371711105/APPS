/**
* 命名空间: Apps.IDAL
* 功 能： N/A
* 类 名： Class1
* 创建时间： 2017/1/5 22:01:56 
* 创建人：小强
* 电子邮箱：371711105@qq.com
*/
using Apps.Models;
using System.Linq;
namespace App.IDAL
{
    public interface ISysUserRepository
    {
        IQueryable<SysUser> GetList(DBContainer db);
        int Create(SysUser entity);
        int Delete(string id);
        void Delete(DBContainer db, string[] deleteCollection);
        int Edit(SysUser entity);
        SysUser GetById(string id);
        bool IsExist(string id);
    }
}
