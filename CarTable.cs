using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskWithCar
{
    public class CarTable
    {
        public string Vin;
        public string Marka;
        public string Model;

        public CarTable(string vin, string marka, string model)
        {
            Vin = vin;
            Marka = marka;
            Model = model;
        }
    }
}