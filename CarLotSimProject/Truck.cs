using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimProject
{
    public class Truck : Car
    {
        public bool TruckBed { get; set; }

        public Truck(string make, string model, int year, int price, bool newOrUsed, bool truckBed)
        {
            Make = make;
            Model = model;
            Year = year;
            PriceInDollars = price;
            New = newOrUsed;
            TruckBed = truckBed;
        }
        public override void Start()
        {
            Console.WriteLine("Baaaah!");
        }
    }
}
