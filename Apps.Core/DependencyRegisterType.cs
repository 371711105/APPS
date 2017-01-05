﻿/**
* 命名空间: Apps.Core
* 功 能： N/A
* 类 名： Class1
* 创建时间： 2016/12/21 19:57:17 
* 创建人：小强
* 电子邮箱：371711105@qq.com
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Apps.BLL;
using Apps.DAL;
using Apps.IBLL;
using Apps.IDAL;
using Microsoft.Practices.Unity;

namespace Apps.Core
{
    public class DependencyRegisterType
    {
        //系统注入
        public static void Container_Sys(ref UnityContainer container)
        {
            container.RegisterType<ISysSampleBLL, SysSampleBLL>();//样例
            container.RegisterType<ISysSampleRepository, SysSampleRepository>();

            container.RegisterType<IHomeBLL, HomeBLL>();
            container.RegisterType<IHomeRepository, HomeRepository>();

            container.RegisterType<ISysLogBLL, SysLogBLL>();
            container.RegisterType<ISysLogRepository, SysLogRepository>();

            container.RegisterType<ISysExceptionBLL, SysExceptionBLL>();
            container.RegisterType<ISysExceptionRepository, SysExceptionRepository>();

            container.RegisterType<IAccountBLL, AccountBLL>();
            container.RegisterType<IAccountRepository, AccountRepository>();

            container.RegisterType<ISysModuleBLL, SysModuleBLL>();
            container.RegisterType<ISysModuleRepository, SysModuleRepository>();

            container.RegisterType<ISysModuleOperateBLL, SysModuleOperateBLL>();
            container.RegisterType<ISysModuleOperateRepository, SysModuleOperateRepository>();

            container.RegisterType<ISysUserBLL, SysUserBLL>();
            container.RegisterType<ISysRightRepository, SysRightRepository>();

            //container.RegisterType<ISysUserBLL, SysUserBLL>();
            //container.RegisterType<ISysUserRepository, SysUserRepository>();

            container.RegisterType<ISysRoleBLL, SysRoleBLL>();
            container.RegisterType<ISysRoleRepository, SysRoleRepository>();

            container.RegisterType<ISysRightBLL, SysRightBLL>();
            container.RegisterType<ISysRightRepository, SysRightRepository>();
        }
    }
}