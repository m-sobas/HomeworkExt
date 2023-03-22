using HomeworkExt.Core.Application.Extensions;
using HomeworkExt.Core.Application.Interfaces;
using HomeworkExt.Core.Models;
using HomeworkExt.Core.Models.Domains;
using HomeworkExt.Core.Models.ViewModels;
using HomeworkExt.Infrastructure;
using HomeworkExt.Infrastructure.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkExt.Core.Application.Controllers
{
	public class CarController : Controller
	{
		private ICarService _carService;

		public CarController(ICarService carService)
		{
			_carService = carService;
		}

		public IActionResult Index()
		{
			var userId = User.GetUserId();
			var cars = _carService.GetCars(userId);

			var vm = new CarsViewModel
			{
				Cars = cars,
				BrandList = _carService.GetBrands(cars),
				Filters = new Filters()
			};

			return View(vm);
		}

		[HttpPost]
		public IActionResult Index(CarsViewModel viewModel)
		{
			var userId = User.GetUserId();

			var cars = _carService.GetCars(userId,
				new Filters
				{
					Brand = viewModel.Filters.Brand,
					Model = viewModel.Filters.Model,
					Year = null, //2020, //viewModel.YearList.First(),
								 //Fuel = viewModel.FilterCars.Fuel,
					Fuel = null, //(FuelType)1,
					PriceFrom = 0,
					PriceTo = 1000000
				});

			var vm = new CarsViewModel
			{
				Cars = cars
			};

			return PartialView("_CarsList", vm);
		}

		[HttpPost]
		public JsonResult GetModels(string id)
		{
			var userId = User.GetUserId();

			return Json(new SelectList(
				_carService.GetCars(userId)
						   .Select(x => new { x.Brand, x.Model })
						   .Where(x => x.Brand == id)
						   .Select(x => x.Model)
						   .Distinct()
						   .OrderBy(x => x)
						   .ToList()
						   ));
		}

		[Authorize]
		public IActionResult Add()
		{
			//throw new Exception("Kod błędu 123");

			return View();
		}

		//[Authorize]
		public IActionResult Edit(int id)
		{
			var userId = User.GetUserId();

			var car = id == 0 ? new Car { Id = 0, UserId = userId } : _carService.GetCar(id, userId);

			var vm = new CarViewModel
			{
				Car = car,
				Fuel = _carService.GetCars(userId).Select(x => x.Fuel).Distinct().OrderBy(x => x).ToList()
			};

			return View(vm);
		}

	}
}
