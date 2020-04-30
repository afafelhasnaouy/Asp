using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlateformeConcours.Models
{
    public class Parametre
    {
        public int ID { get; set; }
        //doit etre une date calculer a revoir apres !!
        public int DelaiSignup { get; set; }
        public string Titre { get; set; }
        public int PlaceVacante { get; set; }
        public bool Resultats { get; set; }
        //liste des candidats est dispo ou non (boolean)
        public bool ListePrincipaleB3 { get; set; }
        public bool ListeAttenteB3 { get; set; }
        public bool ListPrincipaleB4 { get; set; }
        public bool ListAttenteB3 { get; set; }

    }
}