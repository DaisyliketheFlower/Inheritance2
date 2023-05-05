using System;
using System.Xml.Linq;

namespace Inheritance2
{
	public class Bird: Animal_class
	{
		public Bird()
		{
            BreathesAir = true;
            Legs = 2;
            HasTail = true;
            CanSwim = false;
            HasFeathers = true;
        }



        //Specific Members to Birds
        public bool CanFly { get; set; }
        public bool HasFeathers { get; set; }
        public bool CanSing { get; set; }
        public bool BuildsNest { get; set; }
        public bool HasTail { get; set; }
        public bool BreathesAir { get; set; }
        public bool CanSwim { get; set; }

        public void PrintDetails()
        {


            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Can Fly: {CanFly}");
            Console.WriteLine($"Can Sing: {CanSing}");
            Console.WriteLine($"Can Swim: {CanSwim}");

        }


    }


    

}
		
	


