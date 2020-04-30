using PlateformeConcours.Models;
using PlateformeConcours.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlateformeConcours.Controllers
{
    public class ResultsController : Controller
    {
		private ApplicationDbContext DBcontext;
		public ResultsController(ApplicationDbContext DBcontext)
		{
			this.DBcontext = DBcontext;
		}
		// GET: Results
		public ActionResult Index(int filiere)
        {
			var Filiere = DBcontext.Filieres.Find(filiere);
			if(Filiere == null)
			{
				return Redirect("/");
			}
			ResultViewModel vc = new ResultViewModel();
			vc.Parametre = (from p in DBcontext.Parametres select p).FirstOrDefault();
			if(vc.Parametre != null)
			{
				vc.Admis = vc.Parametre.ListAttenteB3;
				string find = vc.Admis ? "admis" : "preselectionne";
				vc.Title = Filiere.Titre;
				vc.Etudiants3a = (from e in DBcontext.Etudiants3a where e.Etudiant.Filiere.ID == filiere && (e.Etudiant.Etat != null && e.Etudiant.Etat.Equals(find) ) orderby e.Etudiant.Filiere.ID,e.Etudiant.Nom  select e.Etudiant).ToList();
				vc.Etudiants4a = (from e in DBcontext.Etudiants4a where e.Etudiant.Filiere.ID == filiere && (e.Etudiant.Etat != null && e.Etudiant.Etat.Equals(find)) orderby e.Etudiant.Filiere.ID,e.Etudiant.Nom select e.Etudiant).ToList();
				if(vc.Admis)
				{
					vc.Etudiants3aAttend = (from e 
											in DBcontext.Etudiants3a
											where e.Etudiant.Filiere.ID == filiere 
											&& (e.Etudiant.Etat != null && e.Etudiant.Etat.Equals("attente")) 
											&& e.Etudiant.Note != null
										   orderby ((e.Etudiant.Note.NoteMath*e.Etudiant.Note.Specialite)/2) descending
										   select e.Etudiant).ToList();
					vc.Etudiants4aAttend = (from e
											in DBcontext.Etudiants4a
											where e.Etudiant.Filiere.ID == filiere
											&& (e.Etudiant.Etat != null && e.Etudiant.Etat.Equals("attente"))
											&& e.Etudiant.Note != null
											orderby e.Etudiant.Note.Specialite descending
											select e.Etudiant).ToList();
				}
			}
			return View(vc);
        }
    }
}