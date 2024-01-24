using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;
using Core.Utilities.Results;
using Business.Constants;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal) 
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SucessResult(Message.ProductAdded);
        }

        public IDataResult<List<Car>> CarDailyPrice()
        {
            _carDal.GetAll(c => c.DailyPrice > 0);
            return new SuccessDataResult<List<Car>>(Message.ProductsListed);
        }

        public IDataResult<List<Car>> CarNameController()
        {
            _carDal.GetAll(c=>c.Description.Length>2);
            return new SuccessDataResult<List<Car>>(Message.ProductsListed);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==13)
            {
                return new ErrorDataResult<List<Car>>(Message.MaintenanceTime);
            }
            else
            {
                return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Message.ProductsListed);
            }
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailDtos()
        {
            
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), Message.ProductsListed);

        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id), Message.ProductsListed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id), Message.ProductsListed);
        }
    }
}
