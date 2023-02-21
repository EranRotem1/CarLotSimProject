using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimProject
{
    public class CarLot
    {
        public static List<Car> cars = new List<Car>();
        public static void PrintDetails()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car} Details: ");
            }


        }

    }
}
