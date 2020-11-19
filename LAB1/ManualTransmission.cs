using System;
namespace LAB1
{
    public class ManualTransmission : GearBox, IManualTransmission
    {
        private double[] gearRatio;
        private int currentGear;

        public ManualTransmission(double[] gearRatio, int currentGear)
        {
            this.gearRatio = gearRatio;
            this.currentGear = currentGear;
        }

        public double[] GearRatio { get => gearRatio; set => gearRatio = value; }
        public int CurrentGear { get => currentGear; set => currentGear = value; }

        public void shiftUp()
        {
            this.currentGear += 1;
            Console.WriteLine("Shift up, new gear: " + this.currentGear);
        }

        public void shiftDown()
        {
            this.currentGear -= 1;
            Console.WriteLine("Shift down, new gear: " + this.currentGear);
        }

        public void reverse()
        {
            this.currentGear = -1;
            Console.WriteLine("Reverse, new gear: R");
        }
    }
}
