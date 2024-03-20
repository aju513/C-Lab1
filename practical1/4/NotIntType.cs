using System;
using System.Collections.Generic;

class NotIntType
{
    private Dictionary<string, string> data;

    public NotIntType()
    {
        data = new Dictionary<string, string>();
    }

    // Indexer as a string
    public string this[string key]
    {
        get
        {
            if(data.ContainsKey(key))
                return data[key];
            else
                throw new KeyNotFoundException();
        }

        set
        {
            data[key] = value;
        }
    }
}

// class Program{
//     static void Main(string[], args){
//         NotIntType dictionary = new NotIntType();

//         // Setting Data using indexer
        
//         dictionary["Key1"] = "Value 1";
//         dictionary["Key2"] = "Value 2";
//         dictionary["Key3"] = "Value 3";

//         // Accessing values using indexer
//         Console.WriteLine(dictionary["Key1"]);
//         Console.WriteLine(dictionary["Key2"]);
//         Console.WriteLine(dictionary["Key3"]);
//     }
// }