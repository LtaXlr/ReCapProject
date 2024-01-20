using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarService carService = new CarManager(new EfCarDal());

            foreach (var car in carService.CarDailyPrice())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
