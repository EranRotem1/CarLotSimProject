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
        public Luxury()
        {
            New = true;
        }
        public override void Start()
        {
            Console.WriteLine("Papapaaa Pa!");
        }
    }
}
