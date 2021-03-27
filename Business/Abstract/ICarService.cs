﻿using Entities.Concrete;
using Entities.DTos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
        void Add(Car car);
        List<CarDetailDto> GetCarDetails();
        void Delete(Car car);
        void Update(Car car);

    }
}
