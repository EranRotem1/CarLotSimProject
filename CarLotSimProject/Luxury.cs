using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimProject
{
    public class Luxury : Car
    {
        public bool LuxuryFeatures { get; set; }
        public Luxury(string make, string model, int year, int price, bool electric)
        {
            Make= make;
            Model= model;
            Year= year;
            PriceInDollars= price;
            New = true;
            Electric= electric;
        }
        public override void Start()
        {
            Console.WriteLine("Papapaaa Pa!");
        }
    }
}
