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
            CarTest();
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand
            {
                Name = "Peugeot"
            });
            foreach (var color in brandManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car
            //{

            //ColorId=3,
            //ModelYear="2019",
            //DailyPrice=985,
            //Description="Audi A6",
            //BrandId=1,

            //});

            foreach (var car in carManager.GetCarDetailDtos())
            {
                Console.WriteLine(car.BrandName + "/" + car.Description + "/" + car.ColorName + "/" + car.DailyPrice);
            }
        }
    }
}
