using PlateformeConcours.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlateformeConcours.Repositories
{
	public interface IFiliereRepository
	{
		List<Filiere> All();
	}
}