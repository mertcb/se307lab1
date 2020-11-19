using System;
namespace LAB1
{
    public class AutomaticTransmission : GearBox, IAutomaticTransmission
    {
        private double[] gearRatio;
        private int currentGear;

        public AutomaticTransmission(double[] gearRatio, int currentGear)
        {
            this.gearRatio = gearRatio;
            this.currentGear = currentGear;
        }

        public double[] GearRatio { get => gearRatio; set => gearRatio = value; }
        public int CurrentGear { get => currentGear; set => currentGear = value; }

        public void setGear(int gear)
        {
            this.currentGear = gear;
            Console.WriteLine("Gear set, new gear: " + this.currentGear);
        }

        public void reverse()
        {
            this.currentGear = -1; // -1 for reverse gear
            Console.WriteLine("Reverse, new gear: R");
        }
    }
}
