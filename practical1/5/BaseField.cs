using System;

namespace NccLabAju
{
    public class Animal
    {
        public string color = "white";
    }

    public class Dog : Animal
    {
        string color = "black";

        public void showColor()
        {
            Console.WriteLine("Base Color:" + base.color);

            Console.WriteLine("New Color:" + color);
        }
    }
}
// public static void Main(){
// Dog d = new Dog();
//     d.showColor();
//     Console.WriteLine("Lab No:1");
//     Console.WriteLine("Name:Aju Maharjan");
//     Console.WriteLine("Roll no:38,Section:B");
// }
