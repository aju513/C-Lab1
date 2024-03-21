using System;
using System.Collections.Generic;
using NccLabAju;

<<<<<<< HEAD
// class Program
// {
//     static void Main(string[] args)
//     {
//         DerivedClass md = new DerivedClass();
//         DerivedClass md1 = new DerivedClass(15);
//         Console.WriteLine("Number = " + md1.GetNum());
//         Console.WriteLine("Lab No:1");
//         Console.WriteLine("Name:Aju Maharjan");
//         Console.WriteLine("Roll no:38,Section:B");
//     }
// }


=======
class Program
{
    static async Task Main(string[] args)
    {
        await SayHelloAsync();
    }

    static async Task SayHelloAsync()
    {
        HttpClient client = new HttpClient();
        string result = await client.GetStringAsync(
            "https://fakerapi.it/api/v1/persons?_quantity=1&_gender=male&_birthday_start=2005-01-01"
        );
        Console.WriteLine(result);
    }
}
>>>>>>> e9ac224ddf04783592b6eeb7002e77a20df24597
