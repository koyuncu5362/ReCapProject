using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
            Console.WriteLine("Ürün Eklendi Ürün Açıklaması: " + car.Description);
        }

        public void Delete(Car car)
        {

            _carDal.Delete(car);
        }

      
        public String GetById(int carId)
        {
            //List<Car> searchedCar = _carDal.GetById(carId);
            var emptyText = "";
            foreach (var item in _carDal.GetAll())
            {
                if (item.Id == carId)
                {
                    emptyText = "Aradığınız Ürünün Açıklaması: " + item.Description;
                }
            }
            return emptyText;

        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
