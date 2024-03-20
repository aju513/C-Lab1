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

    //      StaticConstructor d1 = new StaticConstructor();
    //         Console.WriteLine("Hello from main");
    //         Console.WriteLine("value of count= " + StaticConstructor.count);
    //         StaticConstructor d2 = new StaticConstructor();
    //         Console.WriteLine("value of count= " + StaticConstructor.count);
    //         Console.WriteLine("Lab No:1");
    //         Console.WriteLine("Name:Aju Maharjan");
    //         Console.WriteLine("Roll no:38,Section:B");
}
