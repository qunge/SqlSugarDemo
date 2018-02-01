﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SqlSugar;


namespace SqlSugarDemo.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        public ActionResult Login()
        {
            var db = SqlSugar.Framework.BaseConfig.GetInstance();
            db.CodeFirst.InitTables(typeof(SqlSugar.Model.UserInfo));
            return View();
        }
	}
}