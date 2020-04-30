using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlateformeConcours.Models
{
    public class AncienEpreuve
    {
        public int ID { get; set; }
        public string Titre { get; set; }
        public string Annee { get; set; }
        public int Niveau { get; set; }
        public string File { get; set; }
    }
}