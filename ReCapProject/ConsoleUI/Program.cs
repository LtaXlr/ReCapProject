using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new InMemoryCarDal());
foreach (var carmanager in carManager.GetAll())
{
    Console.WriteLine(carmanager.Description);
}