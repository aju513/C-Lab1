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
            Console.WriteLine("Default Name is : " + name);
        }


    }
}
