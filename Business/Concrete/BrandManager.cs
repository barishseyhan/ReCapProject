using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void Add(Brand brand)
        {
            if(brand.BrandName.Length > 2)
            {
                _brandDal.Add(brand);
                Console.WriteLine(brand + " markası eklendi");
            }
            else
            {
                Console.WriteLine("Lüften en az iki karakter girin");
            }
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine(brand + " markası silimdi.");
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetBrandById(int id)
        {
            return _brandDal.Get(p => p.BrandId == id);
        }

        public void Update(Brand brand)
        {
            if(brand.BrandName.Length > 2)
            {
                _brandDal.Update(brand);
                Console.WriteLine(brand + " marka güncellendi.");
            }
        }
    }
}
