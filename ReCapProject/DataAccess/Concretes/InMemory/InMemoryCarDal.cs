using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> cars;
        public InMemoryCarDal()
        {
            /*cars = new List<Car>() {
                new Car {Id=1, BrandId=1,ColorId=1,DailyPrice=23000,ModelYear=2000,Description="mercedes bir mavi otomotiv"},
                new Car {Id=2, BrandId=2,ColorId=1,DailyPrice=43000,ModelYear=2002,Description="bmw bir mavi otomotiv"},
                new Car {Id=3, BrandId=1,ColorId=2,DailyPrice=63000,ModelYear=2003,Description="mercedes bir sarı otomotiv"},
            };*/
        }
        public InMemoryCarDal(List<Car> cars)
        {

        }
        public void add(Car car)
        {
            cars.Add(car);
        }

        public void delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public void delte(Car car)
        {
            /*var deletedEntity = cars.SingleOrDefault(c=>c.Id == car.Id);
            cars.Remove(deletedEntity);*/
        }

        public Car get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> getAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetAllDetailCar()
        {
            throw new NotImplementedException();
        }

        public List<Car> getBtBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> getCars(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void update(Car car)
        {
            /*var updatedEntity = cars.SingleOrDefault(c=>c.Id==car.Id);
            cars.Remove(updatedEntity);
            cars.Add(car);*/
        }
    }
}
