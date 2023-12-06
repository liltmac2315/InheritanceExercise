using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             */ /* Creatively display the class member values 
             */
            
            var MyBird = new Bird();
            MyBird.WingColor = "Blue";
            MyBird.CanFly = true;
            MyBird.WillMigrate = true;
            MyBird.beakLength = 3.5;









            /*Create an object of your Reptile class
            *  give values to your members using the object of your Reptile class
            *  
            * Creatively display the class member values 
            */

            var Lizard = new Reptile()
            {
                IsColdBlooded = true,
                IsScaly = true,
                Habitat = "Swamp",
                CanGrowTail = true,
            };

            var MyAnimals = new Animal[] { MyBird, Lizard };

            foreach (var animal in MyAnimals)
            {
                Console.WriteLine($"Alive:{animal.IsAlive}");
                Console.WriteLine($"Age:{animal.Age} years old");
                Console.WriteLine($"It has {animal.LegCount} legs");
                Console.WriteLine($"It lives by :{animal.LandSeaAir}");
                Console.WriteLine("");
            }

        }
    }
}
