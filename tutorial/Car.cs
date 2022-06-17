using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Car
    {
        public string carColor = "red";
        public string carType = "SUV";
        public void showSpeed(int speed = 60)
        {
            Console.WriteLine("This car velocity is " + speed + " km/h");
        }
        public void stopEngine()
        {
            Console.WriteLine("This car is going to stop");
        }
    }
}
