using System;

namespace NccLabAju
{
    class StaticConstructor
    {
        public static int count = 0;

        public StaticConstructor()
        {
            Console.WriteLine("Hello from Instance Constructor");
            count++;
        }

        static StaticConstructor()
        {
            Console.WriteLine("Hello from Static Constructor");
            count = 400;
        }
    }

    // static void Main(string[] args)
    // {
    //     StaticConstructor d1 = new StaticConstructor();
    //     Console.WriteLine("Hello from main");
    //     Console.WriteLine("value of count= " + StaticConstructor.count);
    //     StaticConstructor d2 = new StaticConstructor();
    //     Console.WriteLine("value of count= " + StaticConstructor.count);
    // }
}
