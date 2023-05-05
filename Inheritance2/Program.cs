using System;
using System.Xml.Linq;
using Inheritance2;

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





        // TODO Be sure to follow best practice when creating your classes

        // Create a class Animal
        // give this class 4 members that all Animals have in common - DONE


        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class - DONE

        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class - DONE




        /*Create an object of your Bird class
         *  give values to your members using the object of your Bird class
         *  
         * Creatively display the class member values 
         */


        var kingFisher = new Bird()
        {
            BuildsNest = true,
            CanFly = true,
            CanSing = true,
            Name = "King Fisher",
            CanSwim = false
        };

        /*Create an object of your Reptile class
         *  give values to your members using the object of your Reptile class
         *  
         * Creatively display the class member values 
         */
        

       var snake = new Reptile()
       {
           HasForkedTongue = true,
           HasScales = true,
           Movement = true,
           Legs = 0,
           Name = "Rattlesnake"
       };

        kingFisher.PrintDetails();
        Console.WriteLine();

        snake.PrintDetails();

        var penguin = new Bird() { CanFly = false, CanSwim = true, CanSing = false, Name = "penguin" };
        var gator = new Reptile() { HasForkedTongue = false, CanSwim = true, Movement = true, Name = "Gator" };

            Console.WriteLine();
        penguin.PrintDetails();
        Console.WriteLine();
        gator.PrintDetails();

    }

}
    



