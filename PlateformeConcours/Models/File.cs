using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlateformeConcours.Models
{
    public class File
    {
        public int ID { get; set; }
        public string FileName { get;set; }
        public string FileType { get; set; }
        public string FileYear { get; set; }
        public string FileFaceUpload { get; set; }
        public string FileBackUpload { get; set; }
        [Required]
        [ForeignKey("Diplome")]
        public int DiplomeId { get; set; }
        public virtual Diplome Diplome { get; set; }
        [Timestamp]
        public byte[] CreatedAt;
        [Timestamp]
        public byte[] UpdatedAt;

    }
}