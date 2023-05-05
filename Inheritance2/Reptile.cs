using System;
using System.Xml.Linq;

namespace Inheritance2
{
    public class Reptile : Animal_class
    {
        public Reptile()
        {

        }

        public bool BreathesAir {get;set;}
        public int legs { get; set; }
        public bool HasTail { get; set; }
        public bool CanSwim { get; set; }
        public bool IsColdBlooded { get; set; }



        //properties

        public bool Movement { get; set; }

        public bool HasScales { get; set; }

        public bool HasForkedTongue { get; set; }








        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Is Cold-Blooded:{IsColdBlooded}");
            Console.WriteLine($"Movement: {Movement}");
            Console.WriteLine($"Forked Tongue: {HasForkedTongue}");

        }


    }
    
       
}
		
	


