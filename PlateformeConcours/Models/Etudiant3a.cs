using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlateformeConcours.Models
{
    public class Etudiant3a
    {
        public int ID { get; set; }
        [ForeignKey("Etudiant")]
        public int EtudiantId { get; set; }
        public virtual Etudiant Etudiant { get; set; }
        
    }
}