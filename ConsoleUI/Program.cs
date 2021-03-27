using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandCrudTest();
            //ColorCrudTest();
            //CarCrudTest();
            //CarDetails();

        }

        private static void CarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Car:" + car.CarName, "Price" + car.DailyPrice, "Color:" + car.ColorName);
            }
        }

        private static void CarCrudTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { ColorId = 5, BrandId = 7, DailyPrice = 350, Description = "Dizel, Manuel", ModelYear = "2018" });

            carManager.Update(new Car { CarId = 4, ColorId = 3, BrandId = 5, DailyPrice = 350, Description = "Benzinli, Manuel", ModelYear = "2020" });

            carManager.Delete(new Car { CarId = 3 });
        }

        private static void ColorCrudTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "Black" });
            Console.WriteLine("Black color added");

            colorManager.Update(new Color { ColorId = 4, ColorName = "White" });
            Console.WriteLine("Color with id 4 is updated to white");

            colorManager.Delete(new Color { ColorId = 3 });
        }

        private static void BrandCrudTest()
        {
            BrandManager brandManager = new BrandManager (new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Opel" });
            Console.WriteLine("Brand is added!");

            brandManager.Delete(new Brand { BrandId = 5 });
            Console.WriteLine("The brand with ID 5 has been deleted");

            brandManager.Update(new Brand { BrandId = 2, BrandName = "Seat" });
        }
    }
}
