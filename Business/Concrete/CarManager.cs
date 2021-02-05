using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetCars()
        {
            // iş kodları var.
            return _carDal.GetAll();   
        }

        public List<Car> GetCarsById(int Id)
        {
            return _carDal.GetById(Id);
        }
    }
}
