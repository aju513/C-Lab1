using System;


/*
Theory:
Anonymous method is a block of code, which is used as a parameter for the delegate. It can use generic
parameter types like any other method.
It allows us to define a method inline withourt explicitly declaring a seperate named method.
*/

// copy below code in program.cs
// class Program{
//     static void Main(string[] args){
//         Action printHello = delegate(){
//             Console.WriteLine("Hello!");
//         };

//         printHello();

//         Action<string> greet = delegate(string name){
//             Console.WriteLine("Hello, " + name + "!");
//         };

//         greet("Bishal Shrestha");
//     }
// }

