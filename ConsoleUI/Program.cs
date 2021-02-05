using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetCars())
            {
                Console.WriteLine(car.Description);
            }

            foreach (var car in carManager.GetCarsById(3))
            {
                Console.WriteLine("Id'si " + car.Id + " olan arabanın bilgileri: " + car.Description + " günlük ücreti:" + car.DailyPrice + "TL");
            }
        }
    }
}
