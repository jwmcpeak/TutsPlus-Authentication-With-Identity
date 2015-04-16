﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IdentityFromScratch.Models;
using Microsoft.AspNet.Identity;

namespace IdentityFromScratch.Controllers
{
    [Authorize(Roles="accounting,admin")]
    public class AccountingController : BaseController
    {
        // GET: Accounting
        public ActionResult Index()
        {
            //var roles = UserManager.GetRolesAsync(User.Identity.GetUserId());

            if (User.IsInRole(SecurityRoles.Admin))
            {
                return Content("welcome to accounting");
            }
            else
            {
                return Content("get to back work");
                
            }
        }
    }
}