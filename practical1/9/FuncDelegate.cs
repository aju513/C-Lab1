using System;

/*
Theory:
.NET has provided three predefined delegates:
a) Func
b) Action
c) predicate

Func:
It is the simplest words, func is a generic delegate introduced with .NET 3.5, which can be used with a 
delegate that has returned value. It represents a delegate that can point to a method with zero or more input 
parameters and a return value.
*/


// copy below code to program.cs
// class Program
// {
//     static void Main(string[] args){
//         Func<int> getrandomNumber = () =>
//         {
//             Random random = new Random();
//             return random.Next(1, 100);
//         };

//         Console.WriteLine("Random Number: " + getrandomNumber());

//         Func<string, string> greet = (name) =>{
//             return "Hello, " + name + "!";
//         };

//         Console.WriteLine(greet("Bishal Shrestha"));
//     }
// }