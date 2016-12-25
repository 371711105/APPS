
using Apps.Models;
/**
* 命名空间: Apps.DAL
* 功 能： N/A
* 类 名： ISysLogRepository
* 创建时间： 2016/12/25 12:41:48 
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
    public interface ISysLogRepository
    {
        int Create(SysLog entity);
        void Delete(DBContainer db, string[] deleteCollection);
        IQueryable<SysLog> GetList(DBContainer db);
        SysLog GetById(string id);
    }
}
