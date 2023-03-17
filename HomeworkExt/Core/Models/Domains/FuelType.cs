using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace HomeworkExt.Core.Models.Domains
{
	public enum FuelType
	{
		[Display(Name = "Benzyna")]
		Petrol,

		Diesel,

		[Display(Name = "Hybryda")]
		Hybrid
	}
}
