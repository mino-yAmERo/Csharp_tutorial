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

            //Default Constructor
            Dota2Hero alchemist = new Dota2Hero(); 
            alchemist.getHeroInfo();
            float dmg = alchemist.receiveMagicDmg(500F);

            //Constructor with name parameter
            Dota2Hero invoker = new Dota2Hero("Invoker"); 
            invoker.getHeroInfo();

            //Constructor with multi parameters
            Dota2Hero pangolier = new Dota2Hero("Pangolier", "Agi", 300, 0.25F); 
        }
    }
}



   