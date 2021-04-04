using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTos;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentCarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter=null)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join r in context.Rentals
                             on c.CarId equals r.CarId

                             select new RentalDetailDto
                             {
                                 ModelName = c.ModelName,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 RentDate = r.RentDate,
                                 DailyPrice = c.DailyPrice

                             };
                return result.ToList();




            }
                
        }

        
    }
}
