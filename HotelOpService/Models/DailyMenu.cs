using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelOpService.Models
{
    public class DailyMenu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string[] Tags { get; set; }
        public DateTime Dated { get; set; }
    }
}