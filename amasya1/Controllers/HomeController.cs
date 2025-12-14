using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace amasya1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetSlides()
        {
            var list = new[]
            {
                new
                {
                     Title = "Amasya Merkez",
                     Title1 = "Alçak Köprü",
                     Description = "Alçak Köprü",
                     Image = "/Images/348673,amasyajpg.png",
                     Thumb = "/Images/348673,amasyajpg.png"
                },
                new
                {
                     Title = "Taşova",
                     Title1 = "BORABOY GÖLÜ",
                     Description = "Boraboy Gölü",
                     Image = "/Images/348674,amasyaboraboyjpg.png",
                     Thumb = "/Images/348674,amasyaboraboyjpg.png"
                },
                
                new
                {
                     Title = "Amasya",
                     Title1 = "Yalıboyu Evi",
                     Description = "Gece Görünümü",
                     Image = "/Images/348677,amasyagecefotografijpg.png",
                     Thumb = "/Images/348677,amasyagecefotografijpg.png"
                },
                new
                {
                     Title = "Amasya",
                     Title1 = "Gün Batımı",
                     Description = "Yeşil Irmak",
                     Image = "/Images/348678,amasyagunbatimijpg.png",
                     Thumb = "/Images/348678,amasyagunbatimijpg.png"
                },
                new
                {
                     Title = "Amasya",
                     Title1 = "Müze",
                     Description = "Elmalı Mozaik",
                     Image = "/Images/348679,amasyamozaik-1jpg.png",
                     Thumb = "/Images/348679,amasyamozaik-1jpg.png"
                },
                
                new
                {
                     Title = "Amasya",
                     Title1 = "KirazlıDere",
                     Description = "Sabuncuoğlu Evi",
                     Image = "/Images/348682,amasyasabuncuoglujpg.png",
                     Thumb = "/Images/348682,amasyasabuncuoglujpg.png"
                },
               
                
              
                new
                {
                     Title = "Taşova",
                     Title1 = "Boraboy",
                     Description = "Boraboy Gölü",
                     Image = "/Images/348686,amasyatasovaboraboyjpg.png",
                     Thumb = "/Images/348686,amasyatasovaboraboyjpg.png"
                },
 
                new
                {
                     Title = "Amasya",
                     Title1 = "Arkeoloji",
                     Description = "Gezi",
                     Image = "/Images/348688,amasyaarkeolojikmuzesijpg.png",
                     Thumb = "/Images/348688,amasyaarkeolojikmuzesijpg.png"
                },
                new
                {
                     Title = "Taşova",
                     Title1 = "Tabiat Parkı",
                     Description = "Doğal Göl",
                     Image = "/Images/348690,amasyaboraboytabiatparkijpg.png",
                     Thumb = "/Images/348690,amasyaboraboytabiatparkijpg.png"
                },
             
                new
                {
                     Title = "Merkez",
                     Title1 = "Evler",
                     Description = "Gece Ambiansı",
                     Image = "/Images/348692,amasyagecejpg.png",
                     Thumb = "/Images/348692,amasyagecejpg.png"
                },
                new
                {
                     Title = "Amasya",
                     Title1 = "Merkez",
                     Description = "Genel Görünüm",
                     Image = "/Images/348695,amasyagenelmanzarajpg.png",
                     Thumb = "/Images/348695,amasyagenelmanzarajpg.png"
                },
   
                new
                {
                     Title = "Amasya",
                     Title1 = "Harşena Dağı",
                     Description ="Harşena Dağı",
                     Image = "/Images/348698,amasyakalesijpg.png",
                     Thumb = "/Images/348698,amasyakalesijpg.png"
                },
                
                new
                {
                     Title = "Amasya",
                     Title1 = "Gece",
                     Description = "Gece foto",
                     Image = "/Images/348705,amasyagecefotografi.png",
                     Thumb = "/Images/348705,amasyagecefotografi.png"
                },
                new
                {
                     Title = "Merkez",
                     Title1 = "panoramik",
                     Description = "Genel Görünüm",
                     Image = "/Images/348706,amasyapanoramik.png",
                     Thumb = "/Images/348706,amasyapanoramik.png"
                },
                new
                {
                     Title = "Medrese",
                     Title1 = "Kapı Ağa",
                     Description = "Eğitim yeri",
                     Image = "/Images/350072,amasyabuyukagamedresesijpg.png",
                     Thumb = "/Images/350072,amasyabuyukagamedresesijpg.png"
                },
                new
                {
                     Title = "Amasya",
                     Title1 = "Sultan II. Bayezid Külliyesi",
                     Description = "Büyük bir yapı",
                     Image = "/Images/355684,amasyasultanbayezidkulliyesi.png",
                     Thumb = "/Images/355684,amasyasultanbayezidkulliyesi.png"
                },
              
                new
                {
                     Title = "Amasya",
                     Title1 = "Müze",
                     Description = "Arkeoloji",
                     Image = "/Images/357053,amasyaarkeolojikmuze.png",
                     Thumb = "/Images/357053,amasyaarkeolojikmuze.png"
                },



            };


            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}
