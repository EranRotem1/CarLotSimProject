using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimProject
{
    public class CarFactory
    {
        public static IVehicle MakeCar() 
        {
            Console.WriteLine("Type of Car? SUV, Truck, Electric, Luxury");
            var type = Console.ReadLine();
            Console.WriteLine("Car Make?");
            string make = Console.ReadLine();
            Console.WriteLine("Car Model?");
            string model = Console.ReadLine();
            Console.WriteLine("Car Year?");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Car Price?");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("New? Y or N");
            string ans = Console.ReadLine();
            bool newOrUsed = (ans.ToLower() == "y");
            switch (type.ToLower()) 
            {
                case "electric":
                    return new Electric(make, model, year, price, newOrUsed);

                case "suv":
                    return new SUV(make, model, year, price, newOrUsed) ;

                case "truck":
                    Console.WriteLine("Has truck bed?");
                    var ans3 = Console.ReadLine();
                    bool truckBed = ans3.ToLower() == "y";
                    return new Truck(make, model, year, price, newOrUsed, truckBed);

                case "luxury":
                    Console.WriteLine("Electric Car? Y or N");
                    string ans2 = Console.ReadLine();
                    bool elec = ans.ToLower() == "y";
                    return new Luxury(make, model, year, price, elec);

                default:
                    Console.WriteLine("Not a valid Input\nPlease select between : \nElectric, Luxury, SUV, or Truck (not case sensitive)");
                    return MakeCar();
            }
        }
    }
}
