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
            //RentalCrudTest();
            //UserCrudTest();           
            //CustomerCrudTest();
        }

        private static void CustomerCrudTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer
            {
                CompanyName = "abc",
            });
            customerManager.Update(new Customer
            {
                CustomerId = 2,
                CompanyName = "Seat"

            });
            customerManager.Delete(new Customer
            {
                CustomerId = 3
            });
        }

        private static void UserCrudTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User
            {
                FirstName = "Ahmet",
                LastName = "Aslan",
                Email = "ahmetaslan@gmail.com",
                Password = "12345"

            });
            userManager.Update(new User
            {
                UserId=1,
                FirstName = "Ayşe",
                LastName = "Döndü",
                Email = "aysedondu@gmail.com",
                Password = "85236"

            });
            userManager.Delete(new User
            {
                UserId = 2
            });
        }

        private static void RentalCrudTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental
            {
                CarId = 1,
                CustomerId = 1,
                RentDate = Convert.ToDateTime(6 / 7 / 2020),
                ReturnDate = Convert.ToDateTime(6 / 7 / 2020)
            });
            rentalManager.Update(new Rental
            {
                RentId=2,
                CarId = 1,
                CustomerId = 1,
                RentDate = Convert.ToDateTime(6 / 7 / 2020),
                ReturnDate = Convert.ToDateTime(6 / 7 / 2020)

            });
            rentalManager.Delete(new Rental
            {
                CarId = 1
            });
        }
        private static void CarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data) 
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
