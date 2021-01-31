using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=150,ModelYear="2015",Description="Honda"},
                new Car{Id=2,BrandId=2,ColorId=2,DailyPrice=1000,ModelYear="2019",Description="Cadillac"},
                new Car{Id=3,BrandId=3,ColorId=3,DailyPrice=350,ModelYear="2017",Description="Alfa Romeo"},
                new Car{Id=4,BrandId=4,ColorId=4,DailyPrice=850,ModelYear="2020",Description="Audi"},
                new Car{Id=5,BrandId=5,ColorId=5,DailyPrice=500,ModelYear="2016",Description="BMW"},
            };
        }
        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(c => c.Id == id).ToList();
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            var entity = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(entity);
        }
        public void Update(Car car)
        {
            var entity = _car.SingleOrDefault(c => c.Id == car.Id);
            entity.Id = car.Id;
            entity.BrandId = car.Id;
            entity.ColorId = car.Id;
            entity.ModelYear = car.ModelYear;
            entity.DailyPrice = car.DailyPrice;
            entity.Description = car.Description;
        }
    }
}