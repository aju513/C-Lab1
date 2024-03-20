using System;

namespace NccLabAju
{
    class PrivateConstructor
    {
        private PrivateConstructor() { }

        public static int counter = 0;

        public static int increment()
        {
            return counter + 1;
        }
    }
    //  static void Main(string[] args)
    // {
    //     PrivateConstructor.counter = 5;

    //     Console.WriteLine(
    //         "Using Private Constructor increment value:" + PrivateConstructor.increment()
    //     );
    //     Console.WriteLine("Lab No:1");
    //     Console.WriteLine("Name:Aju Maharjan");
    //     Console.WriteLine("Roll no:38,Section:B");
    // }
}
