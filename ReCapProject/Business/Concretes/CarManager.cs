using Business.Abstracts;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;
        public CarManager(ICarDal CarDal)
        {
            _CarDal = CarDal;
        }
        public Result Add(Car car)
        {
            if (car.Description.Length<3 && car.DailyPrice<0)
            {
                return new ErrorResult(TurkishMessages.AddedCarRentalError);
            }
            _CarDal.add(car);
            return new SucessResult(TurkishMessages.AddedCarRental);
        }

        public DataResult<List<Car>> GetCars()
        {
            return new SuccessDataResult<List<Car>>(_CarDal.getAll(),TurkishMessages.CarsListed);
        }

        public DataResult<List<Car>> getCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_CarDal.getAll(c=>c.ColorId==id),TurkishMessages.CarsColorListed);
        }

        public DataResult<List<CarDetailDto>> GetCarsDetailDto()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_CarDal.GetAllDetailCar(),TurkishMessages.CarsDetailListed);
        }

    }
}
