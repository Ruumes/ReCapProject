using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTos
{
    public class CarDetailDto: IDto
    {
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }

    }
}
