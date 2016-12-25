
using Apps.Models;
/**
* 命名空间: Apps.IDAL
* 功 能： N/A
* 类 名： IHomeRepository
* 创建时间： 2016/12/25 11:38:52 
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
    public interface IHomeRepository
    {
        List<SysModule> GetMenuByPersonId(string moduleId);
    }
}
