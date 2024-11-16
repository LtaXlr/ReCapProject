using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /*ICarService carService = new CarManager(new EfCarDal());
        foreach (var car in carService.GetCarsDetailDto().Data)
        {
            Console.WriteLine(car.CarName);
            Console.WriteLine(car.ColorName);
            Console.WriteLine(car.CarName);
            Console.WriteLine(car.DailyPrice);
            Console.WriteLine(car.BrandName);
        }*/
        IRentalService rentalService = new RentalManager(new EfRentalDal());
        /*Rental myrental = new Rental() { CarId = 1, CustomerId = 1, RentDate = DateTime.Now, ReturnDate = null };
        var result = rentalService.add(myrental);
        Console.WriteLine(result.Message,' ',result.Success);*/
        foreach (var item in rentalService.getAll().Data)
        {
            Console.WriteLine(item.RentId);
        }
    }
}