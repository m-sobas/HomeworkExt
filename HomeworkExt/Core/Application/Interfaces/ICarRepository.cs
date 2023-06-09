﻿using HomeworkExt.Core.Models;
using HomeworkExt.Core.Models.Domains;
using HomeworkExt.Core.Models.ViewModels;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Collections;
using System.Collections.Generic;

namespace HomeworkExt.Core.Application.Interfaces
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars(string userId, Filters filter = null);

		Car GetCar(string userId, int id);

        void Add(Car car);

        void Update(Car car);

        void Delete(int id, string userId);
    }
}
