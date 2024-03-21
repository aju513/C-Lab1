using System;

/*
    Theory:
    C# Enumerations are a user-defined Value Type; inother words an enumeration allocates mermory in a stack
    and works on a Last In First Out approach. They are strongly typed constants, which allow us to assign symbolic names
    to the integral values.
*/

public enum DayOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

// copy below in program.cs
// class Program 
// {
//     static void Main(string[] args){
//         DayOfWeek today = DayOfWeek.Sunday;

//         switch(today){
//             case DayOfWeek.Sunday:
//                 Console.WriteLine("It's Sunday!");
//                 break;

//             case DayOfWeek.Monday:
//                 Console.WriteLine("It's Monday!");
//                 break;
            
//             case DayOfWeek.Tuesday:
//                 Console.WriteLine("It's Tuesday!");
//                 break;
            
//             case DayOfWeek.Wednesday:
//                 Console.WriteLine("It's Wednesday!");
//                 break;
            
//             case DayOfWeek.Thursday:
//                 Console.WriteLine("It's Thursday!");
//                 break;

//             case DayOfWeek.Friday:
//                 Console.WriteLine("It's Friday!");
//                 break;

//             case DayOfWeek.Saturday:
//                 Console.WriteLine("It's Saturday!");
//                 break;

//             default:
//                 Console.WriteLine("It's another day!");
//                 break;
//         }
//     }
// }
