using System;

namespace OOP_Demo
{
    // This is an example of Abstraction.  In my example, I'm not letting the user name a standalone Sandwich

    class Sandwiches
    {
        public string Name { get; set; }
        public bool HasBread { get; set; }
        public bool HasSomethingInTheMiddle { get; set; }
        public int NumberOfCondiments { get; set; }

    }

    // This is an example of Inheritance

    class Hotdog : Sandwiches
    {
        public bool HasTubeOfMeat { get; set; }
    }

    // This is an example of Encapsulation

    private string CreateHotDog(Hotdog hotdog)
    {
        
    }

    //  This is an example of Polymorphism

    
}








        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
