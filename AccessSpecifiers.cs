using System;


namespace MCA_2025
{
    internal class AccessSpecifiers
    {
   
            public string Model = "Toyota"; // Accessible from anywhere

            public void DisplayModel()
            {
                Console.WriteLine($"Car Model: {Model}");
            }
        }


    }
