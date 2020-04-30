using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlateformeConcours.Repositories
{
	public interface ICaheRepository
	{
		string Get(string key);
		void Set(string key, string value);
	}
}
