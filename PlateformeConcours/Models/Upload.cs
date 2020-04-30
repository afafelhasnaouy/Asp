using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlateformeConcours.Models
{
    public class Upload
    {
        //public int ID { get; set; }
        [Key, ForeignKey("Etudiant")]
        public int EtudiantUploadId { get; set; }
        public string FichierPdf { get; set; }
        public string Photo { get; set; }
        public string FileYear { get; set; }
        public virtual Etudiant Etudiant { get; set; }
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
        [Timestamp]
        public byte[] CreatedAt;
        [Timestamp]
        public byte[] UpdatedAt;
    }
}