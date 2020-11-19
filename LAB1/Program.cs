using System;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car(registrationNumber: 1730134, year: 2006, licenseNumber: "10 NE 488");

            Engine engine = new Engine(1.3, "Diesel", 69, 6);
            Body body = new Body(4, "Glass");
            Tire tire = new Tire(15.0, 32.0f);
            Brake brake = new Brake("ABS");
            Wheel wheel = new Wheel(21.0);
            Suspension suspension = new Suspension(0.4f);
            double[] gearRatio = { 0.5 };
            //ManualTransmission manual = new ManualTransmission(gearRatio, 0);
            AutomatedManualTransmission automatedManualTransmission = new AutomatedManualTransmission(gearRatio, 0);
            car.Engine = engine;
            car.Brake = brake;
            car.Body = body;
            car.Tire = tire;
            car.Wheel = wheel;
            car.Suspension = suspension;
            car.Automated = automatedManualTransmission;

            car.Engine.ignite();
            car.Automated.shiftUp();
            car.moveForward();
            car.Automated.shiftUp();
            car.Automated.shiftDown();
            car.Automated.shiftDown();
            car.Brake.apply();
            car.stop();
            car.Automated.reverse();
            car.moveBackward();
            car.moveBackward();
            car.Brake.apply();
            car.stop();
            car.Automated.setGear(3);
        }
    }
}
