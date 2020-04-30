using PlateformeConcours.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlateformeConcours.ViewModel
{
    public class ProfileViewModel
    {
        public Etudiant etudiant { get; set; }
        public ProfileViewModel()
        {
            etudiant = new Etudiant();
        }
    }
}