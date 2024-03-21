using System;

/*
Theory:
A Delegate in C# is similar to a function pointer in C or C++. It's a new type of object in C#. A delegarte is a very
special type of objectm as mentioned earlier. The entire object we used to define contained datra, but a delegate 
contains the details of a method.
Delegate are need to pass a method as a parameter og other methods when dealing with events.
Types: Singlecast Delegate and Multicast Delegate

example: public delegate void DelegateExample();
*/

public delegate void MyDelegate(string message);

public class MyClass
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

//         MyDelegate delegate1 = new MyDelegate(obj.Method1);
//         MyDelegate delegate2 = new MyDelegate(obj.Method2);

//         // INvoking the delegates
//         delegate1("Hello from delegate1");
//         delegate2("Hello from delegate2");
//     }
// }