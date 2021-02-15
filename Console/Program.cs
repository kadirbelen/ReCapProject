using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                ColorId=2,
                ModelYear="2020",
                DailyPrice=0,
                Description= "wolsvagen polo"
            });
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Description);
            }
        }
    }
}
