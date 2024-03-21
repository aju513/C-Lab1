using System;

/*
    Theory:
    A stucture in C# is simply a composite data type consisting of a number elements of other types. A C#
    structure is a value type and the instances ot objects of a structure are created in stack. The structure in C# can contain
    fields, methods, constants, constructors, properties, indexers, operators and even other structure types.
*/

public struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"Point: ({X}, {Y})");
    }
}

// Copy below code in program.cs
// class Program{
//     static void Main(string[] args){
//         Point point = new Point(3,5);

//         Console.WriteLine("Point X coordinate: " + point.X);
//         Console.WriteLine("Point Y coordinate: " + point.Y);
//         point.Display();
//     }
// }