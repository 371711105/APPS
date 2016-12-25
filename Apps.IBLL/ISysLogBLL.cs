
using Apps.Common;
using Apps.Models;
/**
* 命名空间: Apps.IBLL
* 功 能： N/A
* 类 名： ISysLogBLL
* 创建时间： 2016/12/25 12:58:19 
* 创建人：小强
* 电子邮箱：371711105@qq.com
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.IBLL
{
    public interface ISysLogBLL
    {
        List<SysLog> GetList(ref GridPager pager, string queryStr);
        SysLog GetById(string id);
    }
}
