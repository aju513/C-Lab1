using System;

namespace NccLabAju
{
    public class BaseClass
    {
        int num;

        public BaseClass()
        {
            Console.WriteLine("in BaseClass()");
        }

        public BaseClass(int i)
        {
            num = i;
            Console.WriteLine("in BaseClass(int i)");
        }

        public int GetNum()
        {
            return num;
        }
    }

    public class DerivedClass : BaseClass
    {
        // This constructor will call BaseClass.BaseClass()
        public DerivedClass()
            : base() { }

        // This constructor will call BaseClass.BaseClass(int i)
        public DerivedClass(int i)
            : base(i) { }
    }
}

// static void Main(string[] args)
// {
//     DerivedClass md = new DerivedClass();
//     DerivedClass md1 = new DerivedClass(15);
//     Console.WriteLine("Number = " + md1.GetNum());
//     Console.WriteLine("Lab No:1");
//     Console.WriteLine("Name:Aju Maharjan");
//     Console.WriteLine("Roll no:38,Section:B");
// }
