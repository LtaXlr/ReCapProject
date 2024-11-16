using Core.DataAccess.Concretes.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCarDal : BaseEntityFrameworkRepsitory<Car, ReCapProjectDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetAllDetailCar()
        {
            using (ReCapProjectDatabaseContext context = new ReCapProjectDatabaseContext())
            {
                var result = from car in context.Cars
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             join brand in context.Brandss
                             on car.BrandId equals brand.BrandId
                             select new CarDetailDto {BrandName=brand.BrandName,CarName=car.CarName,DailyPrice=car.DailyPrice,ColorName = color.ColorName};
                return result.ToList();
            }
        }
    }
}
