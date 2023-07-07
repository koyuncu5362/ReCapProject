using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

CarManager carManager = new CarManager(new InMemoryCarDal());
carManager.Update(new Car { Id = 4, BrandId = 7, ColorId = 9, ModelYear = "2022", DailyPrice = 900, Description = "10.El" });
carManager.Add(new Car() { Id = 5, BrandId = 5, ColorId = 7, ModelYear = "19/07/2029", DailyPrice = 500, Description = "5.El" });
carManager.Delete(new Car() { Id = 2 });
Console.WriteLine(carManager.GetById(2));

foreach (var car in carManager.GetAll())
    Console.WriteLine(car.Id + " " + car.Description + " " + car.ModelYear);
