using System.Reflection;

namespace CarLotSimProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = CarFactory.MakeCar();
            Console.WriteLine(CarLot.cars.Count);

            var suv1 = CarFactory.MakeCar();
            Console.WriteLine(CarLot.cars.Count);

            var car2 = new Truck("Ram","X", 2017, 32000, false, true);
            Console.WriteLine(CarLot.cars.Count);
            CarLot.PrintDetails();
        }
    }
}