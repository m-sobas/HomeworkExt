using HomeworkExt.Core.Models;
using HomeworkExt.Core.Models.Domains;
using HomeworkExt.Core.Models.ViewModels;
using System.Collections.Generic;

namespace HomeworkExt.Core.Application.Interfaces
{
    public interface ICarService
    {
        IEnumerable<Car> GetCars(string userId, Filters filter = null);

        Car GetCar(int id, string userId);

        void Add(Car car);

        void Update(Car car);

        void Delete(int id, string userId);
    }
}

