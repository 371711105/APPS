/**
* 命名空间: Apps.Common
* 功 能： N/A
* 类 名： JsonHandler
* 创建时间： 2016/12/25 17:01:27 
* 创建人：小强
* 电子邮箱：371711105@qq.com
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Common
{
    public class JsonHandler
    {

        public static JsonMessage CreateMessage(int ptype, string pmessage, string pvalue)
        {
            JsonMessage json = new JsonMessage()
            {
                type = ptype,
                message = pmessage,
                value = pvalue
            };
            return json;
        }
        public static JsonMessage CreateMessage(int ptype, string pmessage)
        {
            JsonMessage json = new JsonMessage()
            {
                type = ptype,
                message = pmessage,
            };
            return json;
        }
    }

    public class JsonMessage
    {
        public int type { get; set; }
        public string message { get; set; }
        public string value { get; set; }
    }
}
