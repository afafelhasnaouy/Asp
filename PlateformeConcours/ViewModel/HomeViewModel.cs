using PlateformeConcours.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlateformeConcours.ViewModel
{
	public class HomeViewModel
	{
		public ModelStateDictionary Errors { get; set; }
		public List<Filiere> Filieres { get; set; }
		public string Cne;
		public string Cin;
		public string ErrorMessage;
        public Etudiant etudiant;
        public HomeViewModel()
        {
            etudiant = new Etudiant();
        }
	}
}