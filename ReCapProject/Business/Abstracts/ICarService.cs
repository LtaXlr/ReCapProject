using Core.Utilities.Results;
using Entities.Concretes;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICarService
    {
        Result Add(Car car);
        DataResult<List<Car>> GetCars();
        DataResult<List<CarDetailDto>> GetCarsDetailDto();
        DataResult<List<Car>> getCarsByColorId(int id);
    }
}
