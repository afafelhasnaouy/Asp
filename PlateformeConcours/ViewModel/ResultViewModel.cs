using PlateformeConcours.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlateformeConcours.ViewModel
{
	public class ResultViewModel
	{
		public bool Admis { get; set; }
		public string Title { get; set; }
		public Parametre Parametre { get; set; }
		public List<Etudiant> Etudiants3a { get; set; }
		public List<Etudiant> Etudiants4a { get; set; }
		public List<Etudiant> Etudiants3aAttend { get; set; }
		public List<Etudiant> Etudiants4aAttend { get; set; }
	}
}