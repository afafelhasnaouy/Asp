using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PlateformeConcours.Models;

namespace PlateformeConcours.Repositories
{
	public class FiliereRepository : IFiliereRepository
	{
		private ApplicationDbContext DBcontext;

		public FiliereRepository(ApplicationDbContext dbContext)

		{
			this.DBcontext = dbContext;
		}
		public List<Filiere> All()
		{
			return DBcontext.Filieres.ToList();
		}
	}
}