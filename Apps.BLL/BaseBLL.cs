/**
* 命名空间: Apps.BLL
* 功 能： N/A
* 类 名： BaseBLL
* 创建时间： 2016/12/26 22:31:29 
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
    public class BaseBLL
    {
        //用base类去做统一的实例化
        private Entities _entity = new Entities();

        public Entities entity
        {
            get { return _entity; }
        }
    }

    public class Entities
    {
    }
}
