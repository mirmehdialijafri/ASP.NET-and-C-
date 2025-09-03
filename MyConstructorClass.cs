using System;


namespace MCA_2025
{
    class MyConstructorClass
    {
        int a=10;
        public void display()
            {
                Console.Write("Employee"+ a);
            }
        public void display(int a=8)
        {
            Console.WriteLine("Writting from From Display 2" + a);
        }
        public MyConstructorClass()
        {
            Console.WriteLine("Constructor...");
        }
        public MyConstructorClass(int a)
        {
            Console.WriteLine("Overloaded Constructor...");
        }

    }
}
