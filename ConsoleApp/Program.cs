using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandTest();
            //CarTest();
            //RentalAdd();
            //UserTest();
            //CustomerTest();
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.Add(new Customer
            {
                UserId = 1,
                CompanyName = "Kadir Belen"
            });
            if (result.Success)
            {
                foreach (var customer in customerManager.GetAll().Data)
                {
                    Console.WriteLine(customer.UserId + "/" + customer.CompanyName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.Add(new User { FirstName = "Kadir", LastName = "Belen", Email = "Kb52@gmail.com", Password = "12345" });
            if (result.Success)
            {
                foreach (var user in userManager.GetAll().Data)
                {
                    Console.WriteLine(user.FirstName + "/" + user.LastName + "/" + user.Email + "/" + user.Password);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void RentalAdd()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental
            {
                CarId = 1,
                CustomerId = 1,
                RentDate = new DateTime(2021, 02, 15),
                ReturnDate = new DateTime(2021, 02, 21)
            });
            Console.WriteLine(result.Message);
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            //brandManager.Add(new Brand
            //{
            //    Name = "Peugeot"
            //});
            if (result.Success)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.Name);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result1 = carManager.GetAll();
            var result = carManager.GetCarDetailDtos();
            //carManager.Add(new Car
            //{

            //ColorId=3,
            //ModelYear="2019",
            //DailyPrice=985,
            //Description="Audi A6",
            //BrandId=1,

            //});
            if (result.Success)
            {
                //Console.WriteLine(result1.Message);
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "/" + car.Description + "/" + car.ColorName + "/" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
