﻿using Apps.Models.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Apps.Core
{
    public static class ExtendMvcHtml
    {
        /// <summary>
        /// 权限按钮
        /// </summary>
        /// <param name="helper">htmlhelper</param>
        /// <param name="id">控件Id</param>
        /// <param name="icon">控件icon图标class</param>
        /// <param name="text">控件的名称</param>
        /// <param name="perm">权限列表</param>
        /// <param name="keycode">操作码</param>
        /// <param name="href">跳转链接</param>
        /// <returns>html</returns>
        public static MvcHtmlString ToolButton(this HtmlHelper helper, string id, string icon, string text, List<PermModel> perm, string keycode, string href = "javascript:")
        {
            if (perm.Where(a => a.KeyCode == keycode).Count() > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("<a id=\"{0}\" href=\"{3}\" class=\"easyui-linkbutton\" iconCls=\"{1}\" plain=\"true\">{2}</a>", id, icon, text, href);
                //sb.AppendFormat("<a id=\"{0}\" style=\"float: left;\" class=\"l-btn l-btn-plain\">", id);
                //sb.AppendFormat("<span class=\"l-btn-left\"><span class=\"l-btn-text {0}\" style=\"padding-left: 20px;\">", icon);
                //sb.AppendFormat("{0}</span></span></a>", text);
                //if (hr)
                //{
                //    sb.Append("<div class=\"datagrid-btn-separator\"></div>");
                //}
                return new MvcHtmlString(sb.ToString());
            }
            else
            {
                return new MvcHtmlString("");
            }
        }
        /// <summary>
        /// 普通按钮
        /// </summary>
        /// <param name="helper">htmlhelper</param>
        /// <param name="id">控件Id</param>
        /// <param name="icon">控件icon图标class</param>
        /// <param name="text">控件的名称</param>
        /// <param name="href">跳转链接</param>
        /// <returns>html</returns>
        public static MvcHtmlString ToolButton(this HtmlHelper helper, string id, string icon, string text, string href = "javascript:")
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<a id=\"{0}\" href=\"{3} \" class=\"easyui-linkbutton\" iconCls=\"{1}\" plain=\"true\">{2}</a>", id, icon, text, href);
            //sb.AppendFormat("<a id=\"{0}\" style=\"float: left;\" class=\"l-btn l-btn-plain\">", id);
            //sb.AppendFormat("<span class=\"l-btn-left\"><span class=\"l-btn-text {0}\" style=\"padding-left: 20px;\">", icon);
            //sb.AppendFormat("{0}</span></span></a>", text);
            //if (hr)
            //{
            //    sb.Append("<div class=\"datagrid-btn-separator\"></div>");
            //}
            return new MvcHtmlString(sb.ToString());

        }
    }
}