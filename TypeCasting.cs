using System;

namespace MCA_2025
{
    public class TypeCasting
    {
        // Implicit Type Casting      
        public void TypeCasting1()
        {
            int myInt = 100;
            double myDouble = myInt;

            Console.WriteLine("Implicit Casted Double: "+ myDouble);
        }
        // Explicit Type casting
        public void TypeCasting2()
        {
            double myDouble = 5.5;
            int myInt=(int)myDouble;
            Console.WriteLine("Explicit Casted Double into integer: " + myInt);
        }

    }
}
