using Restorant.Models;
using Restorant.Repository;
using Restorant.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restorant.Controllers
{
    public class HomeController : Controller
    {
        RestorantDBEntities objrestorantDBEntities;
        public HomeController()
        {
            objrestorantDBEntities = new RestorantDBEntities();

        }
        public ActionResult Index()
        {
            KlientRep objKlientRep = new KlientRep();
            ArtiklRep objArtiklRep = new ArtiklRep();
            TipNaNaplataRep objTipNaNaplata = new TipNaNaplataRep();
            var objMoreModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>(objKlientRep.siteKlienti(), objArtiklRep.siteArtikli(), objTipNaNaplata.siteTipNaNaplati());

            return View(objMoreModels);
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

        [HttpGet]
        public JsonResult zemiCena(int ArtiklId)
        {
            decimal cena = objrestorantDBEntities.Artikls.SingleOrDefault(model => model.ArtiklId == ArtiklId).ArtiklCena;
            return Json(cena, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Index(NarackaView objNarackaView)
        {
            NarackaRep objNarackaRep = new NarackaRep();
            objNarackaRep.dodadiNaracka(objNarackaView);
            return Json("Vasata naracka e uspesno napravena. ", JsonRequestBehavior.AllowGet);

        }
        

    }
}