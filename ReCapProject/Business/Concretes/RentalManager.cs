using Business.Abstracts;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult add(Rental rental)
        {
            if (rental.ReturnDate == null)
            {
                _rentalDal.add(rental);
                return new SucessResult(TurkishMessages.AddedCarRental);
            }
            _rentalDal.add(rental);
            return new ErrorResult(TurkishMessages.NullReturnDate);
        }

        public IDataResult<List<Rental>> getAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.getAll(),TurkishMessages.RentalsListed);
        }

        public IDataResult<List<Rental>> getAllCarId(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.getAll(r => r.CarId == id), TurkishMessages.RentalCarsListed);
        }
        public IDataResult<List<Rental>> getAllCustomerId(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.getAll(r => r.CustomerId == id), TurkishMessages.RentalCustomersListed);
        }

        public IDataResult<List<Rental>> getById(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.getAll(r=>r.RentId==id),TurkishMessages.RentalListed);
        }
    }
}
