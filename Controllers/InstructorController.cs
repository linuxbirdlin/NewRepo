﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nop.Web.Controllers
{
    public partial class InstructorController : BasePublicController
    {
        public virtual ActionResult Index()
        {
            return View();
        }

    }


}