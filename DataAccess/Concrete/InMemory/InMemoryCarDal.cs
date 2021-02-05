using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=5,ModelYear="2019",DailyPrice=500,Description="Megane dizel otomatik"},
                new Car{Id=2,BrandId=2,ColorId=8,ModelYear="2020",DailyPrice=300,Description="i20 benzin otomatik"},
                new Car{Id=3,BrandId=1,ColorId=3,ModelYear="2019",DailyPrice=350,Description="Clio benzin otomatik"},
                new Car{Id=4,BrandId=2,ColorId=2,ModelYear="2019",DailyPrice=400,Description="Clio dizel otomatik"},
                new Car{Id=5,BrandId=1,ColorId=2,ModelYear="2018",DailyPrice=450,Description="Egea dizel otomatik"}
            };
        }
        
       
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c=>c.Id==car.Id);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c=>c.Id==car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
