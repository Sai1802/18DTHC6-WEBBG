using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WEBBG.Models;

namespace WEBBG.Controllers
{
    public class SiteController : Controller
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        private List<SANPHAM> Laysanpham(int count)
        {
            return db.SANPHAMs.OrderByDescending(a => a.NGAYSANXUAT).Take(count).ToList();
            
        }
        // GET: Site
        public ActionResult Index()
        {
            var spmoi = Laysanpham(4);
            return View(spmoi);
           
        }

        public ActionResult Product()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }


    }
}