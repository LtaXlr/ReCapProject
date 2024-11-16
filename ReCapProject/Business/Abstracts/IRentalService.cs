using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IRentalService
    {
        IResult add(Rental rental);
        IDataResult<List<Rental>> getAll();
        IDataResult<Rental> getAllCarId(int id);
    }
}
