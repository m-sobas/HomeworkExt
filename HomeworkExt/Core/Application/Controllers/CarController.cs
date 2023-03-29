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
			//var filters = new Filters { PriceFrom = 0, PriceTo = 1000000 };
			var cars = _carService.GetCars(userId);

			var vm = new CarsViewModel
			{
				Cars = cars,
				BrandList = _carService.GetBrands(cars)
				//Filters = filters
			};

			return View(vm);
		}

		[HttpPost]
		public IActionResult Index(CarsViewModel viewModel)
		{
			var userId = User.GetUserId();

			var vm = new CarsViewModel
			{
				Cars = _carService.GetCars(userId,
				new Filters
				{
					Brand = viewModel.Filters.Brand,
					Model = viewModel.Filters.Model,
					Year = viewModel.Filters.Year,
					Fuel = viewModel.Filters.Fuel, //(FuelType)1,
					PriceFrom = viewModel.Filters.PriceFrom,
					PriceTo = viewModel.Filters.PriceTo
				})
			};

			return PartialView("_CarsList", vm);
		}

		[HttpPost]
		public JsonResult GetModels(string brand)
		{
			var userId = User.GetUserId();

			return Json(new SelectList(
				_carService.GetModels(userId, brand)
				));
		}

		[HttpPost]
		public JsonResult GetYears(string model)
		{
			var userId = User.GetUserId();

			return Json(new SelectList(
				_carService.GetYears(userId, model)
				));
		}

		//[Authorize]
		public IActionResult Add()
		{
			//throw new Exception("Kod błędu 123");

			return View();
		}

		//[Authorize]
		public IActionResult Edit(int id)
		{
			var userId = User.GetUserId();

			var vm = new CarViewModel
			{
				Car = _carService.GetCar(userId, id)
			};

			return View(vm);
		}

	}
}
