using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EstateRegister.Models.Entity;

namespace EstateRegister.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DistinctMvcDbEntities db=new DistinctMvcDbEntities();   
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]   
        public ActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(TBLKISILER p1)
        {
            db.TBLKISILER.Add(p1);
            db.SaveChanges();
            return View();
        }
    }
}