using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTos
{
    public class RentalDetailDto: IDto
    {
        public int RentId { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int ModelYear { get; set; }
        public DateTime RentTime { get; set; }
        public DateTime ReturnTime { get; set; }
        public string DailyPrice { get; set; }
        public string Description { get; set; }

    }
}
