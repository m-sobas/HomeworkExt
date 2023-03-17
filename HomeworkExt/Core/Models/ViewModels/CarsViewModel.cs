using HomeworkExt.Core.Models.Domains;
using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HomeworkExt.Core.Models.ViewModels
{
	public class CarsViewModel
	{
		public CarsViewModel()
		{
			Filters = new Filters();
			BrandList = new Collection<string>();
			ModelList = new Collection<string>();
		}

		public IEnumerable<Car> Cars { get; set; }

		public IEnumerable<string> BrandList { get; set; }
		
		public IEnumerable<string> ModelList { get; set; }

		public Filters Filters { get; set; }
	}
}
