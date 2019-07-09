using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingMVC.Models
{
    public class Car
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }
    }
}
