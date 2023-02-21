using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimProject
{
    public class CarFactory
    {
        public static IVehicle MakeCar(string type) 
        {
            switch (type.ToLower()) 
            {
                case "electric":
                    return new Electric();

                case "suv":
                    return new SUV();

                case "truck":
                    return new Truck();

                case "luxury":
                    return new Luxury();

                default:
                    Console.WriteLine("Not a valid Input\nPlease select between : \nElectric, Luxury, SUV, or Truck (not case sensitive)");
                    type = Console.ReadLine();
                    return MakeCar(type);
            }
        }
    }
}
