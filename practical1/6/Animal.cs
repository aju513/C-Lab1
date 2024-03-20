//6(a)
using System;

class Animal
{
    public virtual void Speaks()
    {
        Console.WriteLine("The Animal says *brr*");
    }
}

// class Dog : Animal
// {
//     public override void Speaks() //Overriding
//     {
//         Console.WriteLine("The Dog says wooff");
//     }
// }

// class Cat : Animal
// {
//     public new void Speaks() //Hiding/Shadowing
//     {
//         Console.WriteLine("The Cat says MEOW");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Dog dog = new Dog();
//         Cat cat = new Cat();

//         dog.Speaks();
//         cat.Speaks();
//     }
// }