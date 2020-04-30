using PlateformeConcours.DTO;
using PlateformeConcours.Repositories;
using PlateformeConcours.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace PlateformeConcours.Controllers
{
    public class LoginController : Controller
    {
		IStudent _studentRepository;
		ICaheRepository _caheRepository;
		private IFiliereRepository filiereRepository;
        HomeViewModel vm = new HomeViewModel();

        public LoginController(IStudent studentRepository, ICaheRepository caheRepository, IFiliereRepository filiereRepository)
		{
			_studentRepository = studentRepository;
			_caheRepository = caheRepository;
			this.filiereRepository = filiereRepository;
            vm.Filieres = filiereRepository.All();            
		}
        public ActionResult Index()
        {
			if(Session["etudiant"] !=null)
			{
				return Redirect("/profile");
			}
            return View();
        }

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Auth(LoginDTO dto)
		{
			vm = new HomeViewModel();
			vm.Filieres = filiereRepository.All();
			if (!ModelState.IsValid)
			{
				
				vm.Errors = ModelState;
				vm.Cin = dto.Cin;
				vm.Cne = dto.Cne;
				return View("~/Views/Home/Index.cshtml",vm );
			}

			var std = _studentRepository.Login(dto.Cne, dto.Cin, dto.Password);
            if (std != null)
            {
                string uuid = Utils.Utils.generateID();
                _caheRepository.Set(uuid, std.ID.ToString());
                Session["etudiant"] = std;
                return RedirectToAction("Index");
            }

            else
            {
                vm.ErrorMessage = "Les informations d'identification ne sont pas correctes";
                vm.Cin = dto.Cin;
                vm.Cne = dto.Cne;
                return View("~/Views/Home/Index.cshtml", vm);
            }
		}
		public ActionResult Out()
		{
			Session["etudiant"] = null;
			return Redirect("/");
		}
    }
}