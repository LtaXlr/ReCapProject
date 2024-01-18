using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal() 
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=2,DailyPrice=30000,Description="kırmızı bir lamborghini",ModelYear=2000},
                new Car{Id=2,BrandId=1,ColorId=2,DailyPrice=30000,Description="kırmızı bir lamborghini",ModelYear=2000},
                new Car{Id=3,BrandId=2,ColorId=1,DailyPrice=50000,Description="mavi bir bugatti",ModelYear=2019},
                new Car{Id=4,BrandId=2,ColorId=1,DailyPrice=50000,Description="mavi bir bugatti",ModelYear=2019},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var deleteId = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(deleteId);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
        }
    }
}
