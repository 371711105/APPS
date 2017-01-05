﻿
using Apps.Common;
using Apps.Models;
using Apps.Models.Sys;
/**
* 命名空间: Apps.IBLL
* 功 能： N/A
* 类 名： ISysUserBLL
* 创建时间： 2016/12/27 21:31:58 
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
    public interface ISysUserBLL
    {
        List<PermModel> GetPermission(string accountid, string controller);
        List<SysUserModel> GetList(ref GridPager pager, string queryStr);
        bool Create(ref ValidationErrors errors, SysUserModel model);
        bool Delete(ref ValidationErrors errors, string id);
        bool Delete(ref ValidationErrors errors, string[] deleteCollection);
        bool Edit(ref ValidationErrors errors, SysUserModel model);
        SysUserModel GetById(string id);
        bool IsExist(string id);
    }
}
