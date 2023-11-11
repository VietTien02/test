using KiemTra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiemTra.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Cau1()
        {
           
            return View();
        }
        public ActionResult Cau2()
        {
           

            return View();
        }
        public ActionResult KQ(Teacher t)
        {
            t.maGv = Request["magv"];
            t.Hoten = Request["hoten"];

            string temp = "";
            if (Request["Nam"] == "true, false")
                temp = "Nam";
            else
                temp += " " + " Nu";
            t.sex = temp;

            if (t.SoGio < 100)
            {
                t.luong = t.SoGio * t.LuongGio;
            }
            else if (t.SoGio < 200)
            {
                t.luong = t.SoGio * t.LuongGio * 1.1;
            }
            else
            {
                t.luong = t.SoGio * t.LuongGio * 1.2;
            }
            return View(t);
        }
    }
}