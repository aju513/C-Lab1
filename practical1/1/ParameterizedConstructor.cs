using System;

namespace NccLabAju
{
    class ParamaterizedConstructor
    {
        string name;

        public ParamaterizedConstructor(string n)
        {
            name = n;
        }

        public void display()
        {
            Console.WriteLine("Parametarized Name is : " + name);
            Console.WriteLine("");
            Console.WriteLine("Lab No:1");
            Console.WriteLine("Name:Aju Maharjan");
            Console.WriteLine("Roll no:38,Section:B");
        }
    }
}
