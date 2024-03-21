using System;

/*
Theory:
An Action type delegate is the same as Func delegate except that the Action delegate doesn't return a value.
*/

// copy below code to program.cs
// class Program
// {
//     static void Main(string[] args)
//     {
//         Action printHello = () =>
//         {
//             Console.WriteLine("Hello!");
//         };

//         Action<string> greet = (name) =>
//         {
//             Console.WriteLine("Hello, " + name + "!");
//         };

//         printHello();
//         greet("Bishal Shrestha");

//     }
// }