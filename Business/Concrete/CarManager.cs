using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length < 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Succesfully added!");
            }
            else
            {
                Console.WriteLine("The car name must be 2 characters and the daily price of the car must be greater than 0.");
            }
        }

        public List<Car> GetAll()
        {
            
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(p => p.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(p => p.ColorId == colorId);
        }
    }
}
