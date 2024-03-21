//6(a)
using System;

/*
Theory:
Overriding: It is a technique that allows us to re-write a base class function or method with a different defination.
Shadowing/hiding: The child(derived) class has its own version of the function, the same function is also available in the base class.

Observation:
We can say that a function or method in base(parent) class is defined as a virtual function and 
method and the overridden in child class using "override" keyword where as shadowing/hiding is done with 
the help of "new" keyword
*/
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