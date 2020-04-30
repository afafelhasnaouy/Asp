using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlateformeConcours.Models;
using PlateformeConcours.Repositories;
using PlateformeConcours.ViewModel;

namespace PlateformeConcours.Controllers
{
    public class HomeController : Controller
    {
		private IFiliereRepository filiereRepository;

		public HomeController(IFiliereRepository filiereRepository)
		{
			this.filiereRepository = filiereRepository;
		}
		public ActionResult Index(string name="")
        {
			ViewBag.name = name;
			HomeViewModel vm = new HomeViewModel();
			vm.Filieres = filiereRepository.All();
			return View("Index",vm);
			//return db.Etudiants.ToList();
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
    }
}