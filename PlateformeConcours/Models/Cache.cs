using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlateformeConcours.Models
{
	public class Cache
	{
		public int ID { get; set; }
		[StringLength(60)]
		public string Key { get; set; }

		[StringLength(255)]
		public string Value { get; set; }

		[Column(TypeName = "datetime2")]
		public DateTime Expires;
	}
}