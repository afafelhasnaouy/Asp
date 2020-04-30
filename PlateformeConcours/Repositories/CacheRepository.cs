using PlateformeConcours.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlateformeConcours.Repositories
{
	public class CacheRepository : ICaheRepository
	{
		private ApplicationDbContext DBcontext;

		public CacheRepository(ApplicationDbContext dbContext)

		{
			this.DBcontext = dbContext;
		}

		public string Get(string key)
		{
			var res = (from c in DBcontext.Cache where c.Key.Equals(key) select c.Value).FirstOrDefault(null);
			return res;
		}

		public void Set(string key,string value)
		{
			var c = new Cache();
			c.Value = value;
			c.Key = key;
			DBcontext.Cache.Add(c);
			DBcontext.SaveChangesAsync();
		}
	}
}