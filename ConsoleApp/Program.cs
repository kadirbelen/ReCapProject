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
