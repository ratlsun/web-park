using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebParkDemo.Models
{
    public class Park
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OpeningTime { get; set; }
        public int PlaceCount { get; set; }
        public decimal Price { get; set; }
        public string Character { get; set; }
    }
}