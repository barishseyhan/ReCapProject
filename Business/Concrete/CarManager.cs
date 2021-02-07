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

        public void Add(Car car)
        {
            if(car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine(car + " marka araç eklendi.");
            }
            else
            {
                Console.WriteLine("Kiralama bedeli sıfır olamaz");
            }
            
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine(car + " marka araç silindi.");
        }

        public List<Car> GetAll()
        {
           return _carDal.GetAll();
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
        }

        public List<Car> GetByModelYear(string year)
        {
            return _carDal.GetAll(p => p.ModelYear == year);
        }

        public Car GetCarById(int id)
        {
            return _carDal.Get(p => p.Id == id);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine(car + " marka araç güncellendi.");
        }
    }
}
