using HomeworkExt.Core.Models.Domains;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HomeworkExt.Core.Models
{
	public class Filters
	{
		public int CarId { get; set; }

		public string Brand { get; set; }

		public string Model { get; set; }

		public int? Year { get; set; }

		public FuelType? Fuel { get; set; }

		public decimal PriceFrom { get; set; }

		public decimal PriceTo { get; set; }
	}
}
