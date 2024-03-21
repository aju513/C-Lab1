using System;
using Microsoft.VisualBasic;

/*
Theory:
Abstract Class: Also called an "abstract superclass" in object technology, it is a class created as a master structure. No objects
og an abstract class are created; rather, subclasses of the abstract class are defined with their own variations, and the subclasses are used to 
create the actual objects.
*/

// Defining an abstract class
abstract class Shape
{
    public abstract double Area();
    public abstract double Perimeter();
}

class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double Area()
    {
        return width * height;
    }

    public override double Perimeter()
    {
        return 2 * (width * height);
    }

}

class Circle : Shape
{
    private double radius;
    private const double PI = 3.14;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return PI * radius * radius;
    }

    public override double Perimeter()
    {
        return 2 * PI * radius;
    }

}

//Copy below class in program.cs
// class Program
// {
//     static void Main(string[] args)
//     {
//         Rectangle rectangle = new Rectangle(10, 5);
//         Circle circle = new Circle(7.8);

//         Console.WriteLine("The Area of rectangle is: " + rectangle.Area());
//         Console.WriteLine("The Perimeter of rectangle is: " + rectangle.Perimeter());
//         Console.WriteLine("The Area of circle is: " + circle.Area());
//         Console.WriteLine("The Perimeter of circle is: " + circle.Perimeter());


//     }
// }
