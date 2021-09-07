using SanayiBaazarim.Models.siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SanayiBaazarim.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(admin ad)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.kullaniciAdi == ad.kullaniciAdi && x.sifre == ad.sifre && x.id==1);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.kullaniciAdi, false);
                Session["kullaniciAdi"] = bilgiler.kullaniciAdi.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
            
        }
       
    }
}