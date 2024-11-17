using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constant
{
    public static class TurkishMessages
    {
        //Rental
        public static string SystemError = "sistemimizde Bakım var";
        public static string NullReturnDate="araba daha teslim edilmedi";
        public static string AddedCarRental = "araba teslim edildi" ;
        public static string AddedCarRentalError = "araba teslim edildilmedi" ;
        public static string RentalsListed = "kiralananlar listelendi";
        public static string RentalListed = "kiracı listelendi";
        public static string RentalCustomersListed = "araba kiralayanlar listelendi";
        public static string RentalCarsListed = "kiralanan arabalar listelendi";
        //Car
        public static string AddedCar = "araba başarıyla eklendi";
        public static string AddedCarValidationError = "eklenecek olan bu arabanın validasonunda sıkıntı var";
        public static string CarsDetailListed = "araba detayları listelendi";
        public static string CarsListed = "arabalar listelendi";
        public static string CarsColorListed = "arabalar listelendi";
    }
}
