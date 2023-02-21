using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimProject
{
    public class Electric : Car
    {
        public Electric()
        {
            Electric = true;
        }
        public override void Start()
        {
            Console.WriteLine("Meep Meep");
        }
        
    }
}
