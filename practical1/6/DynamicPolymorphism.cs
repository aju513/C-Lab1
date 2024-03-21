using System;

/*
Theory:
Polymorphism: It allows a class to have multiple implementations with the same name. It is one of the core principle 
of OOP after encapsulation and inhertirance.
Types:
1) Static / Compile Time Polymorphism
    a) Method Overloading
    b) Operator Overloading
2 Dynamic / Runtime Polymorphism
    a) Virtual / Overriding Method

Observatio:
We are using Dynamic / Runtime Polymorphism in the following code where 
we have a base class Vehicle which is inheritated in classes Car, Bicycle and Truck 
and the function Go() is overridden and the child class are set as an array as Vehicle[].
*/

// Copy From here to program.cs
class Vehicle
{
    public virtual void Go(){

    }
}

class Car : Vehicle{
    public override void Go()
    {
        Console.WriteLine("The Car is moving.");
    }
}

class Bicycle : Vehicle{
    public override void Go(){
        Console.WriteLine("The Bicycle is moving.");
    }
}

class Truck : Vehicle{
    public override void Go()
    {
        Console.WriteLine("The Truck is moving");
    }
}

// class Program
// {
//     static void Main(string[] args){
//         Car car = new Car();
//         Bicycle bicycle = new Bicycle();
//         Truck truck = new Truck();


//         Vehicle[] vehicles = {car,bicycle, truck};

//         foreach(Vehicle data in vehicles){
//             data.Go();
//         }
//     }
// }
