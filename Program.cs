namespace TaskWithCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarTable car1 = new CarTable("451AA763GX", "Audi", "A3");
            CarTable car2 = new CarTable("233XX876CV", "BMW", "X7");
            CarTable car3 = new CarTable("765LO821NB", "Ford", "Mustang");

            CarTable[] cars = { car1, car2, car3 };

            foreach (CarTable car in cars) 
            Console.WriteLine($"Marka: {car.Marka}, Model: {car.Model}, VIN: {car.Vin}");
        }
        }
}
