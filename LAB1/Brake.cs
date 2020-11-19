using System;
namespace LAB1
{
    public class Brake
    {
        private String type;

        public Brake(string type)
        {
            this.type = type;
        }

        public string Type { get => type; set => type = value; }

        public void apply()
        {
            Console.WriteLine("Brake applied");
        }
    }
}
