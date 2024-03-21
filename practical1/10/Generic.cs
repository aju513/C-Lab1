using System;

public class Pair<T>
{
    public T First { get; set; }
    public T Second { get; set; }

    public Pair(T first, T second)
    {
        First = first;
        Second = second;
    }

    public void PrintPair()
    {
        Console.WriteLine($"First: {First}, Second: {Second}");
    }
}
// static void Main()
//     {

//         Pair<int> intPair = new Pair<int>(10, 20);
//         intPair.PrintPair(); 

//         Pair<string> stringPair = new Pair<string>("Hello", "World");
//         stringPair.PrintPair(); 
//     }
