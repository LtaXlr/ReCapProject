using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from c in context.cars
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             join b in context.brands
                             on c.BrandId equals b.Id
                             select new CarDetailDto { 
                                 Id = c.Id,
                                 ColorName = co.ColorName,
                                 BrandName = b.BrandName,
                                 Description = c.Description,
                             };

                return result.ToList();
            }
        }
    }
}
