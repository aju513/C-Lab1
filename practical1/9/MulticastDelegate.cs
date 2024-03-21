using System;

/*
    Theory:
    This is a type of delegate where it is wrapped with more than one method.
*/

public delegate void DelegateDemo(string message);

public class ClassDemo
{
    public void Method1(string message)
    {
        Console.WriteLine("Method 1: " + message);
    }

    public void Method2(string message)
    {
        Console.WriteLine("Method 2: " + message);
    }
}

// copy below code in program.cs
// class Program
// {
//     static void Main(string[] args){
//         MyClass obj = new MyClass();

//         DelegateDemo delegate1 = new DelegateDemo(obj.Method1);
//         DelegateDemo delegate2 = new DelegateDemo(obj.Method2);

//         // combining delegates to create a multicast delegate
//         DelegateDemo multicast = delegate1 + delegate2;

//         multicast("Here form multicast delegate");
//     }
// }