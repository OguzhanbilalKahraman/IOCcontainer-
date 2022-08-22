using IocContainer.Services;
using IocContainer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IocContainer.Controllers
{
    public class HomeController : Controller
    {
        //ConsoleLogger _log;
        Ilog _log;
        public HomeController(Ilog log)
        {
            _log = log;
        }
        public string  Index([FromServices] Ilog log)
        {
            //ConsoleLogger consolelogger = new ConsoleLogger();
            //consolelogger.Info("Yeni bir istek gelmistir.");
            //return View();
            log.Info("Action bazlı talep yapılmıştır.");
            return "Service Running";


        }
    }
}
