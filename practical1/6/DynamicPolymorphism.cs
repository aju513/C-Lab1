using System;

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
