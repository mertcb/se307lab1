using System;
namespace LAB1
{
    public class Wheel
    {
        private double diameter;

        public double Diameter { get => diameter; set => diameter = value; }

        public Wheel(double diameter)
        {
            this.diameter = diameter;
        }

    }
}
