﻿using HomeworkExt.Core.Application.Interfaces;
using HomeworkExt.Core.Models;
using HomeworkExt.Core.Models.Domains;
using HomeworkExt.Core.Models.ViewModels;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkExt.Infrastructure.Repositories
{
    public class CarRepository : ICarRepository
    {
        private IApplicationDbContext _context;

        public CarRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Car car)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id, string userId)
        {
            throw new System.NotImplementedException();
        }

        public Car GetCar(int id, string userId)
        {
            return _context.Cars
                .Single(x => x.Id == id);
        }

        public IEnumerable<Car> GetCars(string userId, Filters filters = null)
        {
			if (filters == null)
            {
                return _context.Cars
                //.Where(x => x.UserId == userId)
                .ToList();
            }
            else
            {
                var cars = _context.Cars
                    .Where(x => x.Price >= filters.PriceFrom && x.Price <= filters.PriceTo)
                    .ToList();

				if (filters.Brand != null)
					cars = cars.Where(x => x.Brand == filters.Brand).ToList();

				if (filters.Model != null)
                    cars = cars.Where(x => x.Model == filters.Model).ToList();

				if (filters.Year != null)
					cars = cars.Where(x => x.Year == filters.Year).ToList();

				if (filters.Fuel != null)
					cars = cars.Where(x => x.Fuel == filters.Fuel).ToList();

				return cars;
			}
		}

		public void Update(Car car)
        {
            throw new System.NotImplementedException();
        }
    }
}