using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PlateformeConcours.DTO
{
	public class LoginDTO
	{
		[Required]
		[StringLength(10)]
		public string Cne { get; set; }
		[Required]
		[StringLength(8)]
		public string Cin { get; set; }
		[Required]
		public string Password { get; set; }
	}
}