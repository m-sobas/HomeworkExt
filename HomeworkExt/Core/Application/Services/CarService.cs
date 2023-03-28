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

		public Car GetCar(int id, string userId)
		{
			return _unitOfWork.Car.GetCar(id, userId);
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
