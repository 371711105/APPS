﻿using Apps.Models.sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Apps.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {            
            return View();
        }
    }
}