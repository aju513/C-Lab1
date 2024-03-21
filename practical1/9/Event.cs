using System;
using System.Reflection.Metadata;

/*
Theory:
An Event is a language feature that enavles a class or object to provide notifications to other
classes or objects when certain actions or changes occur.
*/

public class MyEventArgs : EventArgs
{
    public string Message { get; set; }

    public MyEventArgs(string message)
    {
        Message = message;
    }
}

public class Publisher
{
    public event EventHandler<MyEventArgs>? MyEvent;
    public void RaiseEvent(string message)
    {
        if (MyEvent != null)
        {
            MyEvent(this, new MyEventArgs(message));
        }
    }
}

public class Subscriber
{
    public Subscriber(Publisher publisher)
    {
        publisher.MyEvent += HandleEvent;
    }

    private void HandleEvent(object? sender, MyEventArgs e)
    {
        Console.WriteLine("Subscriber recieved message: " + e.Message);
    }
}

//copy below in program.cs
// class Program
// {
//     static void Main(string[] args)
//     {
//         // Create instances of publisher and subscriber
//         Publisher publisher = new Publisher();
//         Subscriber subscriber = new Subscriber(publisher);

//         // Raise the event
//         publisher.RaiseEvent("Hello from publisher!");
//     }
// }