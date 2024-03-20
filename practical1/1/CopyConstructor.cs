using System;

namespace NccLabAju
{
    class CopyConstructor
    {
        string name;

        public CopyConstructor(string n)
        {
            name = n;
        }

        public CopyConstructor(CopyConstructor obj)
        {
            name = obj.name;
        }

        public void display()
        {
   
            Console.WriteLine("Copied Name from CopyConsturctor is : " + name);
            Console.WriteLine("");
            Console.WriteLine("Lab No:1");
            Console.WriteLine("Name:Aju Maharjan");
            Console.WriteLine("Roll no:38,Section:B");
        }
    }
}
