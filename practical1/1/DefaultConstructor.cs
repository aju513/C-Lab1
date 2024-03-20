using System;

namespace NccLabAju
{
    class DefaultConstructor
    {
        string name;

        public DefaultConstructor()
        {
            name = "Aju";
        }

        public void display()
        {
            Console.WriteLine("My Name is:" + name);
            Console.WriteLine("");
            Console.WriteLine("Lab No:1");
            Console.WriteLine("Name:Aju Maharjan");
            Console.WriteLine("Roll no:38,Section:B");
        }
    }
}
