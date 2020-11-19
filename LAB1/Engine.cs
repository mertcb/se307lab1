using System;
namespace LAB1
{
    public class Engine
    {
        private double capacity;
        private String fuelType;
        private int horsePower;
        private int numberOfCylinders;

        public Engine(double capacity, string fuelType, int horsePower, int numberOfCylinders)
        {
            this.capacity = capacity;
            this.fuelType = fuelType;
            this.horsePower = horsePower;
            this.numberOfCylinders = numberOfCylinders;
        }

        public double Capacity { get => capacity; set => capacity = value; }
        public string FuelType { get => fuelType; set => fuelType = value; }
        public int HorsePower { get => horsePower; set => horsePower = value; }
        public int NumberOfCylinders { get => numberOfCylinders; set => numberOfCylinders = value; }

        public void ignite()
        {
            Console.WriteLine("Engine Ignited!");
        }
    }
}
