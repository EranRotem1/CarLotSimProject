using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimProject
{
    public class Electric : Car
    {
        public Electric(string make, string model, int year, int price, bool newOrUsed)
        {
            Make = make;
            Model = model;
            Year = year;
            PriceInDollars = price;
            New = newOrUsed;
            Electric = true;
        }
        public override void Start()
        {
            Console.WriteLine("Meep Meep");
        }
        
    }
}
