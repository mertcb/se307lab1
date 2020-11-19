using System;
namespace LAB1
{
    public class Tire
    {
        private double width;
        private float airPressure;

        public Tire(double width, float airPressure)
        {
            this.width = width;
            this.airPressure = airPressure;
        }

        public double Width { get => width; set => width = value; }
        public float AirPressure { get => airPressure; set => airPressure = value; }
    }
}
