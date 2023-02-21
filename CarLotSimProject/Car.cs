using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimProject
{
    public abstract class Car : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int PriceInDollars { get; set; }
        public bool New { get; set; }
        public bool Electric { get; set; }

        public virtual void Start()
        {
            Console.WriteLine("Vroom vroom");
        }

        public Car()
        {
            CarLot.cars.Add(this);
        }
    }
}
