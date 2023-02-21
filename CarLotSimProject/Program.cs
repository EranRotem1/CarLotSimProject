namespace CarLotSimProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = CarFactory.MakeCar("");
            Console.WriteLine(CarLot.cars.Count);

            var suv1 = CarFactory.MakeCar("suv");
            Console.WriteLine(CarLot.cars.Count);

            var car2 = new Truck() { Make = "Ram", Model = "X", TruckBed = true, Electric = false, New = false, PriceInDollars = 32000, Year = 2017 };
            Console.WriteLine(CarLot.cars.Count);
            CarLot.PrintDetails();
        }
    }
}