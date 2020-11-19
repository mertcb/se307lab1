using System;
namespace LAB1
{
    public class Suspension
    {
        private float springRate;

        public Suspension(float springRate)
        {
            this.springRate = springRate;
        }

        public float SpringRate { get => springRate; set => springRate = value; }
    }
}
