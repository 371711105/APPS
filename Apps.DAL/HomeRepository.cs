﻿
using Apps.IDAL;
using Apps.Models;
/**
* 命名空间: Apps.DAL
* 功 能： N/A
* 类 名： HomeRepository
* 创建时间： 2016/12/25 11:40:08 
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
    public class HomeRepository : IHomeRepository, IDisposable
    {

        public List<SysModule> GetMenuByPersonId(string moduleId)
        {
            using (DBContainer db = new DBContainer())
            {
                var menus =
                (
                    from m in db.SysModule
                    where m.ParentId == moduleId
                    where m.Id != "0"
                    select m
                          ).Distinct().OrderBy(a => a.Sort).ToList();
                return menus;
            }
        }

        public void Dispose()
        {

        }
    }
}