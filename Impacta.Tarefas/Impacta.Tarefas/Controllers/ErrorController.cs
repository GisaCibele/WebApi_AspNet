﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Impacta.Tarefas.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult NotFoud()
        {
            return View();
        }
    }
}