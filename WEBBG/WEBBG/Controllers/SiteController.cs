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
        public ActionResult LoaiSp()
        {
            var loaisp = from lsp in data.LOAISPs select lsp;
            return PartailView(loaisp);
        }

        public ActionResult SPTheoLoai(int id)
        {
            var sp = from s in data.SANPHAMs where s.MASP == id select s;
            return View(sp);
        }
       
        public ActionResult NhaCC()
        {
            var nhacc = from ncc in data.NCCs select ncc;
            return PartailView(nhacc);
        }
        public ActionResult SPTheoNCC(int id)
        {
            var sp = from s in data.SANPHAMs where s.MASP == id select s;
            return View(sp);
        }


        public ActionResult Details(int id)
        {
            var sp = from s in data.SANPHAMs
                     where s.MASP == id
                     select s;
            return View(sp.Single());
        }


    }
}