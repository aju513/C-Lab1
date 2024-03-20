using System;

namespace NccLabAju
{
    public class FirstClass
    {
        public virtual void methodrun()
        {
            Console.WriteLine("Called Base Method...");
        }
    }

    public class SecondClass : FirstClass
    {
        public override void methodrun()
        {
            Console.WriteLine("Calling Method from override method");
            base.methodrun();
            Console.WriteLine("New line added by overriding method");
        }
    }
}
// public static void Main()
// {
//     Dog d = new Dog();
//     d.overrideMethod();
//     Console.WriteLine("Lab No:1");
//     Console.WriteLine("Name:Aju Maharjan");
//     Console.WriteLine("Roll no:38,Section:B");
// }
