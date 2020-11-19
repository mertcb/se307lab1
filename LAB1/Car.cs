using System;
namespace LAB1
{
    public class Car
    {
        // properties
        private int registrationNumber;
        private int year;
        private String licenseNumber;
        private ManualTransmission manual;
        private AutomaticTransmission auto;
        private AutomatedManualTransmission automated;
        private Engine engine;
        private Body body;
        private Suspension suspension;
        private Tire tire;
        private Wheel wheel;
        private Brake brake;
        //constructor
        public Car(int registrationNumber, int year, string licenseNumber)
        {
            this.registrationNumber = registrationNumber;
            this.year = year;
            this.licenseNumber = licenseNumber;
        }

        // getters and setters
        public int RegistrationNumber { get => registrationNumber; set => registrationNumber = value; }
        public int Year { get => year; set => year = value; }
        public string LicenseNumber { get => licenseNumber; set => licenseNumber = value; }
        public Engine Engine { get => engine; set => engine = value; }
        public Body Body { get => body; set => body = value; }
        public Suspension Suspension { get => suspension; set => suspension = value; }
        public Tire Tire { get => tire; set => tire = value; }
        public Wheel Wheel { get => wheel; set => wheel = value; }
        public Brake Brake { get => brake; set => brake = value; }
        public ManualTransmission Manual { get => manual; set => manual = value; }
        public AutomaticTransmission Auto { get => auto; set => auto = value; }
        public AutomatedManualTransmission Automated { get => automated; set => automated = value; }

        // methods
        public void moveForward()
        {
            Console.WriteLine("Car moved forward");
        }

        public void moveBackward()
        {
            Console.WriteLine("Car moved backward");
        }

        public void stop()
        {
            Console.WriteLine("Car stopped");
        }

        public void turnLeft()
        {
            Console.WriteLine("Car turned left");
        }

        public void turnRight()
        {
            Console.WriteLine("Car turned right");
        }
    }
}
