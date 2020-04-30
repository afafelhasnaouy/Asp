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
    public class Etudiant : ISoftDelete
    {
        public Etudiant()
        {
            Etudiants3a = new HashSet<Etudiant3a>();
            Etudiants4a = new HashSet<Etudiant4a>();
        }

        public int ID { get; set; }
        [StringLength(30)]
        public string Nom { get; set; }
        [StringLength(30)]
        public string Prenom { get; set; }
        public string NomComplet
        {
            get
            {
                return Nom + " " + Prenom;
            }
        }
        [Required]
        [StringLength(10)]
        //[RegularExpression(@"(^[A-Z]{1})([0-9]{9}$)")]
        public string Cne { get; set; }
        [Required]
        [StringLength(8)]
        public string Cin { get; set; }


        public string Password { get; set; }

        [Required]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "email n'est pas valide.")]
        [StringLength(64)]
        public string Email { get; set; }
        public string Civilite { get; set; }
        public string NumDossier { get; set; }
        //etat peut etre
        public string Etat { get; set; }
        //public enum TypeEtat
        //{
        //    Inscrit,
        //    Preselectionne,
        //    admit
        //}
        //public int Deleted { get; set; }
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public string fichier { get; set; }
        [Column(TypeName = "datetime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //https://stackoverflow.com/questions/18288675/display-datetime-value-in-dd-mm-yyyy-format-in-asp-net-mvc
        public DateTime DateNaiss { get; set; }
        [StringLength(maximumLength: 20, MinimumLength = 5)]
        public string Nationnalite { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Tel { get; set; }
        public string Etablissement { get; set; }

        [ForeignKey("Filiere")]
        public int? ID_Filiere { get; set; }
        public virtual Filiere Filiere { get; set; }
        [Timestamp]
        public byte[] CreatedAt;
        [Timestamp]
        public byte[] UpdatedAt;
        public virtual Diplome Diplome { get; set; }
        public virtual Upload Upload { get; set; }
        public virtual Note Note { get; set; }
        public virtual ICollection<Etudiant3a> Etudiants3a { get; set; }
        public virtual ICollection<Etudiant4a> Etudiants4a { get; set; }


    }
}