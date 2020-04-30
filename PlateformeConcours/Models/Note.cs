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
    public class Note : ISoftDelete
    {
        [Key, ForeignKey("Etudiant")]
        public int EtudiantNoteId { get; set; }
        [Required]
        public double NoteBac { get; set; }
        [Required]
        [Range(0, 20)]
        public double S1 { get; set; }
        [Range(0, 20)]
        public double S2 { get; set; }
        [Range(0, 20)]
        public double S3 { get; set; }
        [Range(0, 20)]
        public double S4 { get; set; }
        [Range(0, 20)]
        public double? S5 { get; set; }
        [Range(0, 20)]
        public double? S6 { get; set; }
        [Required]
        //etudiant a redoubler sa premiere annee (true or false)
        public bool Redoublant1 { get; set; }
        [Required]
        public bool Redoublant2 { get; set; }
        public bool Redoublant3 { get; set; }

        public double? NoteMath { get; set; }
        public double? Specialite { get; set; }
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
        public virtual Etudiant Etudiant { get; set; }
        [Timestamp]
        public byte[] CreatedAt;
        [Timestamp]
        public byte[] UpdatedAt;


    }
}