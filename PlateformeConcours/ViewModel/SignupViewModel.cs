using PlateformeConcours.helpers;
using PlateformeConcours.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlateformeConcours.ViewModel
{
	public class SignupViewModel
	{
        public Etudiant etudiant { get; set; }
        public List<Country> countries { get; set; }
        public SelectList selectC { get; set; }
        public List<Filiere> filiers { get; set; }
        public SelectList selectF { get; set; }
		public string message { get; set; }
		public bool isError { get; set; }
		public string cin { get; set; }
		public string nom { get; set; }
		public string prenom { get; set; }
		public string cne { get; set; }
		public string email { get; set; }
		public SignupViewModel()
		{
            etudiant = new Etudiant();
            countries = new List<Country>();
        }
	}
}