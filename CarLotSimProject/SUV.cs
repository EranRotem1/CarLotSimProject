using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimProject
{
    public class SUV : Car
    {
        public SUV(string make, string model, int year, int price, bool newOrUsed) 
        {
            Make= make;
            Model= model;   
            Year= year; 
            PriceInDollars= price;
            New = newOrUsed;
        }
        public override void Start()
        {
            Console.WriteLine("Honk");
        }
    }
}
