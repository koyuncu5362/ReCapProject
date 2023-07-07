﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
             _cars = new List<Car>()
             {
                 new Car{Id = 1,BrandId = 1,ColorId=2,ModelYear="19/07/2027",DailyPrice=500,Description="1.El"},
                 new Car{Id = 2,BrandId = 3,ColorId=2,ModelYear="19/07/2027",DailyPrice=500,Description="2.El"},
                new Car{Id = 3,BrandId = 2,ColorId=2,ModelYear="19/07/2027",DailyPrice=500,Description="3.El"},
                new Car{Id = 4,BrandId = 1,ColorId=2,ModelYear="19/07/2027",DailyPrice=500,Description="4.El"},
             };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            Console.WriteLine("Silinen Ürün Açıklaması : " + carToDelete.Description);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
