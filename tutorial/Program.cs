// See https://aka.ms/new-console-template for more information
using System;
namespace Tutorial
{
    class Program
    {   
        //attribute
        public string language = "C#";
        public string IDE = "Visual Studio";

        //method
        public void showInfo()
        {
            Console.WriteLine("I'm learning " + language + " with " + IDE + " IDE.");
        }

        //function main
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************");

            //create a new object from class Car
            Car Toyota = new Car();

            //print the value of attribute from class Car
            
            Console.WriteLine(Toyota.carColor);
            Console.WriteLine(Toyota.carType);

            //access method from class Car
            Toyota.stopEngine();
            Toyota.showSpeed(); //Default parameter
            Toyota.showSpeed(80); // pass parameter through method
            Console.WriteLine("****************************************");


            //create a new object from class Program
            Program program = new Program();
            program.showInfo();
            Console.WriteLine("****************************************");


            //create a new object from class Dota2Hero
            Dota2Hero alchemist = new Dota2Hero();
            Console.WriteLine("This hero's name : " + alchemist.hero_name);
            Console.WriteLine("This hero's attribute : "+ alchemist.hero_attribute);
            Console.WriteLine("This hero's movespeed : "+ alchemist.hero_movespeed);
            float dmg = alchemist.receiveMagicDmg(500F);
            Console.WriteLine("alchemist recieve dmg : " + dmg);
            Console.WriteLine("alchemist recieve dmg : " + alchemist.receiveMagicDmg(-500F));
            Console.WriteLine("alchemist recieve dmg : " + alchemist.receiveMagicDmg(-500));
            Console.WriteLine("****************************************");

        }
    }
}



   