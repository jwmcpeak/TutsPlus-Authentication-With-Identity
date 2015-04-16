﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdentityFromScratch.Controllers
{
    [Authorize]
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Index()
        {
            return Content("Index of Company");
        }
        
        [AllowAnonymous]
        public ActionResult EmployeeList()
        {
            if (User.Identity.IsAuthenticated)
            {
                return Content("Private Employee list");

            }
            else
            {
                return Content("Public Employee list");
                
            }
        }
    }
}