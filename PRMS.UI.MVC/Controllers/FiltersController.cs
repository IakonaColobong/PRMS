using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using PRMS.DATA.EF;
using System.Data.Entity;


namespace PRMS.UI.MVC.Controllers
{
    public class FiltersController : Controller
    {
        private PoliceRMSEntities db = new PoliceRMSEntities();
        // GET: Filters
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AmmunitionPaging(string searchString, int page = 1)
        {
            int pageSize = 5;
            var ammunition = db.Ammunitions.OrderBy(a => a.Caliber).ToList();

            //wrote custom query to list ammunition by caliber
            if (!String.IsNullOrEmpty(searchString))
            {
                ammunition = (
                    from a in ammunition
                    where a.Caliber.ToLower().Contains(searchString.ToLower())
                    select a
                    ).ToList();
            }
            ViewBag.SearchString = searchString;
            return View(ammunition.ToPagedList(page, pageSize));



        }

        public ActionResult EmployeePaging(string searchString, int page = 1)
        {
            int pageSize = 5;
            var employee = db.Employees.OrderBy(a => a.First_Name).ToList();

            //wrote custom query to list ammunition by caliber
            if (!String.IsNullOrEmpty(searchString))
            {
                employee = (
                    from a in employee
                    where a.First_Name.Contains(searchString.ToLower()) 
                    select a
                    ).ToList();
            }
            ViewBag.SearchString = searchString;
            return View(employee.ToPagedList(page, pageSize));
        }
    }
}