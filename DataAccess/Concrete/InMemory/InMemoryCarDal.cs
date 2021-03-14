using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car {CarId=1, BrandId=2, DailyPrice=200, ColorId= 1, ModelYear="2018",Description="Otomatik Dizel" },
                new Car {CarId=2, BrandId=4, DailyPrice=150, ColorId= 3, ModelYear="2016",Description="Manuel Dizel" },
                new Car {CarId=3, BrandId=6, DailyPrice=250, ColorId= 2, ModelYear="2019",Description="Otomatik Benzin" },
                new Car {CarId=4, BrandId=8, DailyPrice=100, ColorId= 2, ModelYear="2013",Description="Manuel Benzin" },
                new Car {CarId=5, BrandId=9, DailyPrice=300, ColorId= 4, ModelYear="2020",Description="Manuel Dizel" },


            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);

            _cars.Remove(carToDelete); 
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByCarId(int carId)
        {
           return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
          
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;


        }
    }
}
