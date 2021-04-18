using FixTools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FixTools.Controllers
{
    public class ProgramaMantenimientoController : Controller
    {
        // GET: ProgramaMantenimiento
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProgramaMantenimiento()
        {
            ProgramaMantenimientodModel model = new ProgramaMantenimientodModel();
            return View(model);
        }
    }
}