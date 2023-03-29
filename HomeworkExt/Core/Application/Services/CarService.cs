using HomeworkExt.Core.Application.Interfaces;
using HomeworkExt.Core.Models;
using HomeworkExt.Core.Models.Domains;
using HomeworkExt.Core.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkExt.Core.Application.Services
{
    public class CarService : ICarService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CarService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

		public IEnumerable<Car> GetCars(string userId, Filters filter = null)
		{
			return _unitOfWork.Car.GetCars(userId, filter);
		}

		public IEnumerable<string> GetBrands(IEnumerable<Car> cars)
		{
			return cars.Select(x => x.Brand)
				.Distinct()
				.ToList();
		}

		public IEnumerable<string> GetModels(string userId, string brand)
		{
			return _unitOfWork.Car.GetCars(userId)
				.Select(x => new { x.Brand, x.Model })
				.Where(x => x.Brand == brand)
				.Select(x => x.Model)
				.Distinct()
				.OrderBy(x => x)
				.ToList();
		}

		public IEnumerable<int> GetYears(string userId, string model)
		{
			return _unitOfWork.Car.GetCars(userId)
				.Select(x => new { x.Model, x.Year })
				.Where(x => x.Model == model)
				.Select(x => x.Year)
				.Distinct()
				.OrderBy(x => x)
				.ToList();
		}

		public Car GetCar(string userId, int id)
		{
			return _unitOfWork.Car.GetCar(userId, id);
		}

		public void Add(Car car)
        {
            throw new System.NotImplementedException();
        }

		public void Update(Car car)
		{
			throw new System.NotImplementedException();
		}

		public void Delete(int id, string userId)
        {
            throw new System.NotImplementedException();
        }
    }
}
