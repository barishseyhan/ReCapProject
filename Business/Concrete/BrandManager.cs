using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
        public IResult Add(Brand brand)
        {
            if(brand.BrandName.Length > 2)
            {
                _brandDal.Add(brand);
                //Console.WriteLine(brand + " markası eklendi");
                return new Result(Messages.BrandAdded);
            }
            else
            {
                //Console.WriteLine("Lüften en az iki karakter girin");
                return new ErrorResult(Messages.BrandNameInvalid);
            }
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            //Console.WriteLine(brand + " markası silimdi.");
            return new Result(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            if (DateTime.Now.Hour == 15)
            {
                return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandsListed);
        }

        public IDataResult<Brand> GetBrandById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(p => p.BrandId == id));
        }

        public IResult Update(Brand brand)
        {
            if(brand.BrandName.Length > 2)
            {
                _brandDal.Update(brand);
                //Console.WriteLine(brand + " marka güncellendi.");
                return new Result(Messages.BrandUpdated);
            }
            return new ErrorResult(Messages.BrandNameInvalid);
        }
    }
}
