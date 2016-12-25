
using Apps.Models;
/**
* 命名空间: Apps.IDAL
* 功 能： N/A
* 类 名： ISysExceptionRepository
* 创建时间： 2016/12/25 15:38:23 
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
    public interface ISysExceptionRepository
    {
        int Create(SysException entity);
        IQueryable<SysException> GetList(DBContainer db);
        SysException GetById(string id);
    }
}
