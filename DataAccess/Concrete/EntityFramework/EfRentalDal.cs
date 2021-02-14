using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RecapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (RecapContext context = new RecapContext())
            {
                var result = from rent in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join car in context.Cars
                             on rent.CarId equals car.Id
                             join customer in context.Customers
                             on rent.CustomerId equals customer.Id
                             join user in context.Users
                             on customer.UserId equals user.Id
                             select new RentalDetailDto
                             {
                                 Id = rent.Id,
                                 CustomerName = customer.CompanyName,
                                 CarId = car.Id,
                                 RentDate = rent.RentDate,
                                 ReturnDate = rent.ReturnDate,
                                 UserName = user.FirstName + " " + user.LastName

                             };
                return result.ToList();
            }
        }
    }
}
