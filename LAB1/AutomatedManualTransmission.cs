using System;
namespace LAB1
{
    public class AutomatedManualTransmission : IAutomaticTransmission, IManualTransmission
    {

        private double[] gearRatio;
        private int currentGear;

        AutomaticTransmission auto;
        ManualTransmission manual;

        public double[] GearRatio { get => gearRatio; set => gearRatio = value; }
        public int CurrentGear { get => currentGear; set => currentGear = value; }

        public AutomatedManualTransmission(double[] gearRatio, int currentGear)
        {
            this.gearRatio = gearRatio;
            this.currentGear = currentGear;
            manual = new ManualTransmission(gearRatio, currentGear);
            auto = new AutomaticTransmission(gearRatio, currentGear);
        }

        public void shiftUp()
        {
            manual.shiftUp();
        }

        public void shiftDown()
        {
            manual.shiftDown();
        }

        public void setGear(int gear)
        {
            auto.setGear(gear);
        }

        public void reverse()
        {
            manual.reverse();
        }

    }
}
