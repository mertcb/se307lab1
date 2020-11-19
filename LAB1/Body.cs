using System;
namespace LAB1
{
    public class Body
    {
        private int numberOfDoors;
        private String roofType;

        public Body(int numberOfDoors, string roofType)
        {
            this.numberOfDoors = numberOfDoors;
            this.roofType = roofType;
        }

        public int NumberOfDoors { get => numberOfDoors; set => numberOfDoors = value; }
        public string RoofType { get => roofType; set => roofType = value; }
    }
}
