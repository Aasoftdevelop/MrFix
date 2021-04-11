using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FixTools.Models;
namespace FixTools.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter(string user, string pass)
        {
            try
            {
                using (FixToolsEntities db = new FixToolsEntities())
                {
                    var lst = from d in db.USER
                              where d.TX_EMAIL == user && d.PW_PASSWORD == pass
                              select d;

                    if(lst.Count() >0)
                    {
                        USER oUser = lst.First();
                        Session["User"] = oUser;
                    }
                    else
                    {
                        return Content("Usuario errado");
                    }
                }

                    return Content("1");
            }
            catch(Exception ex)
            {
                return Content("Error" + ex.Message);

            }
            
        }
    }
}