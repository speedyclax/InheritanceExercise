using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal -- DONE
            // give this class 4 members that all Animals have in common -- DONE


            // Create a class Bird -- DONE
            // give this class 4 members that are specific to Bird -- DONE
            // Set this class to inherit from your Animal Class -- DONE

            // Create a class Reptile -- DONE
            // give this class 4 members that are specific to Reptile -- DONE
            // Set this class to inherit from your Animal Class -- DONE




            /*Create an object of your Bird class -- DONE
             *  give values to your members using the object of your Bird class -- DONE
             *  
             * Creatively display the class member values -- DONE
             */
            var Penguin = new Bird();

            Penguin.NumberOfLegs = 2;
            Penguin.CanFly = false;
            Penguin.CanSwim = true;
            Penguin.IsAggressive = false;
            Penguin.Home = "Antartica";
            Penguin.DoesMigrate = false;
            Penguin.FeatherColor = "Black and White";
            Penguin.ChirpSound = "Squawk";
            Penguin.Size = "Medium";

            Console.WriteLine($"Here are your bird's stats:");
            Console.WriteLine();
            Console.WriteLine($"1.Size: {Penguin.Size} | 2.Feather Color: {Penguin.FeatherColor} | 3.Sound of Chirp: {Penguin.ChirpSound} | 4.Bird Size: {Penguin.Size}");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            /*Create an object of your Reptile class -- DONE
             *  give values to your members using the object of your Reptile class -- DONE
             *  
             * Creatively display the class member values -- DONE
             */
            var Lizard = new Reptile();

            Lizard.NumberOfLegs = 4;
            Lizard.CanFly = false;
            Lizard.CanSwim = true;
            Lizard.Home = "Jungle";
            Lizard.IsAggressive= false;
            Lizard.Color = "Green";
            Lizard.HasTail = true;
            Lizard.Size = "Small";
            Lizard.Speed = "Fast";

            Console.WriteLine($"Here are your reptile's stats:");
            Console.WriteLine();
            Console.WriteLine($"1.Size: {Lizard.Size} | 2.Color: {Lizard.Color} | 3.Speed: {Lizard.Speed} | 4.Does It Have a Tail: {Lizard.HasTail}");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
        }
    }
}
