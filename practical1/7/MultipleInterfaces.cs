using System;

/*
Observation:
We can find that the muliple interfaces can be inheritated by a single class 
accoroding to its requirements
*/
interface IAnimal
{
    void Sound();
}

interface IFly
{
    void Fly();
}

interface ISwim
{
    void Swim();
}

class Bird : IAnimal, IFly //Because bird is an animal and it can fly
{
    public void Sound()
    {
        Console.WriteLine("Bird is an Animal");
    }

    public void Fly()
    {
        Console.WriteLine("Bird can fly");
    }
}

class Fish : IAnimal, ISwim // Becasue Fish is an animal and can only swim
{
    public void Sound()
    {
        Console.WriteLine("Fish is an Animal");
    }

    public void Swim()
    {
        Console.WriteLine("Fish can swim");
    }
}


// Copy below code to program.cs
// class Program
// {
//     static void Main(string[] args)
//     {
//         Bird bird = new Bird();
//         Fish fish = new Fish();

//         bird.Sound();
//         bird.Fly();
//         fish.Sound();
//         fish.Swim();
//     }
// }