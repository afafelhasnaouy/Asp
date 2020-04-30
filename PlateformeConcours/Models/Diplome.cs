using PlateformeConcours.Models.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlateformeConcours.Models
{
    public class Diplome : ISoftDelete
    {
        //public int ID { get; set; }
        [Key, ForeignKey("Etudiant")]
        public int EtudiantDiplomeId { get; set; }
        [Required]
        public string Titre { get; set; }
        [Required]
        public string Etablissement { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Annee1 { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Annee2 { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Annee3 { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
        public virtual Etudiant Etudiant { get; set; }
        [Timestamp]
        public byte[] CreatedAt;
        [Timestamp]
        public byte[] UpdatedAt;
    }
}