﻿namespace TaskWithCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("451AA763GX", "Audi", "A3");
            Car car2 = new Car("233XX876CV", "BMW", "X7");
            Car car3 = new Car("765LO821NB", "Ford", "Mustang");

            Car[] cars = { car1, car2, car3 };

            foreach (Car car in cars) 
            Console.WriteLine($"Marka: {car.Marka}, Model: {car.Model}, VIN: {car.Vin}");
        }
        }
}
