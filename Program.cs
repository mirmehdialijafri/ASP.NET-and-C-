using System;

namespace MCA_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            obj.abc();


            AccessSpecifiers car = new AccessSpecifiers();
            Console.WriteLine(car.Model); // Accessible
            car.DisplayModel(); // Accessible
            MyConstructorClass mcon1 = new MyConstructorClass();
            MyConstructorClass mcon=new MyConstructorClass(15);
            mcon.display();
            mcon.display();

            // Getter and Setter
            GetterSetter gs=new GetterSetter();
            gs.Name = "Pune";
            Console.WriteLine();
            Console.WriteLine("Name satter:" + gs.Name);

            // TypeCasting
            Console.WriteLine("Enter a real number");                       
            Console.WriteLine("Entered:"+ Convert.ToString(Console.ReadLine()));
            TypeCasting tc=new TypeCasting();
            tc.TypeCasting1();
            tc.TypeCasting2();
        }
    }
}