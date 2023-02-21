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

        public override void Start()
        {
            Console.WriteLine("Baaaah!");
        }
    }
}
