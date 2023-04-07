using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace HomeworkExt.Core.Models.Domains
{
    public class Car
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Marka")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Model")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Rok produkcji")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Typ paliwa")]
        public FuelType Fuel { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Display(Name = "Cena")]
		[DisplayFormat(DataFormatString = "{0:n0}")]
		public decimal? Price { get; set; }

        public string PhotoFileName { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
