using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();

            //ColorTest();

            //BrandTest();

           
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine($"{brand.BrandId}\t{brand.BrandName}");

            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine($"{color.ColorId}\t{color.ColorName}");
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                Console.WriteLine("Araç Detaylı Liste: \nId\tRenk\tMarka\tModel Yılı\tGünlük Kira\tAçıklamalar ");
                foreach (var car in result.Data)
                {
                    Console.WriteLine($"{car.Id}\t{car.ColorName}\t{car.BrandName}{car.ModelYear}\t{car.DailyPrice}\t\t{car.Description}");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        //private static void AddCar(CarManager carManager)
        //{
        //    Console.WriteLine("Aracın Markasını belirleyin: ");
        //    int BrandId = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Aracın rengini belirleyin: ");
        //    int ColorId = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Aracın Model yılını girin: ");
        //    string ModelYear = Console.ReadLine();
        //    Console.WriteLine("Aracın günlük kiralama bedelini girin: ");
        //    decimal DailyPrice = Convert.ToDecimal(Console.ReadLine());
        //    Console.WriteLine("Araç için açıklama girin: ");
        //    string Description = Console.ReadLine();
        //    Console.Clear();
        //    carManager.Add(new Car
        //    {
        //        BrandId = BrandId,
        //        ColorId = ColorId,
        //        ModelYear = ModelYear,
        //        DailyPrice = DailyPrice,
        //        Description = Description
        //    });
        //}
    }
}
