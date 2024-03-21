using System;
using NccLabAju;

/*
    Theory:
    Interfaces in C# are a powerful tool for achieving abstraction and allowing objects to interact with each other.
    They define a set of methods, properties, and events that a clas must implemet, but do not provide an implementation dor for them.
    This allows for greater flexibility and reusability of code.

    An interface looks like a class but has no implementation. The only thing it contains is declarations
    of events, indexers, methods, and/or properties. The reason interdaces only provide declearations is that 
    they are inherited by structs and classes which must provide an implementation for each interface member declared.
*/

// Defining an interface
interface IShape
{
    double Area();
    double Perimeter();
}

// Classes that implement the inerface
class Triangle : IShape
{
    private double side1;
    private double side2;
    private double side3;

    public Triangle(double side1, double side2, double side3)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public double Area()
    {
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }

    public double Perimeter()
    {
        return side1 + side2 + side3;
    }
}

class Square : IShape
{
    private double side;
    public Square(double side)
    {
        this.side = side;
    }

    public double Area()
    {
        return side * side;
    }

    public double Perimeter()
    {
        return 4 * side;
    }
}

// Copy below code in program.cs
// class Program
// {
//     static void Main(string[] args)
//     {
//         Triangle triangle = new Triangle(3, 4, 5);
//         Square square = new Square(4);

//         Console.WriteLine("The Area of triangle is: " + triangle.Area());
//         Console.WriteLine("The Perimeter of triangle is: " + triangle.Perimeter());
//         Console.WriteLine("The Area of square is: " + square.Area());
//         Console.WriteLine("The Perimeter of square is: " + square.Perimeter());
//     }
// }