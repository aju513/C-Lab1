using System;
using System.Collections.Generic;
using NccLabAju;

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
