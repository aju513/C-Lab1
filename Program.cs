using NccLabAju;

class Program
{
    static void Main(string[] args)
    {
        PropertyDemo pd = new PropertyDemo();
        string fullName = pd.Name;
        Console.WriteLine("Hello " + fullName + "\n");

        pd.Name = "Using Set Property";
        Console.WriteLine(pd._name);
        Console.WriteLine("Lab No:1");
        Console.WriteLine("Name:Aju Maharjan");
        Console.WriteLine("Roll no:38,Section:B");
    }
}
