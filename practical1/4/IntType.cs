using System;

// Theory for (4): 
// Defination: 
// Indexers allow instances of a class or struct to be indexed just like array. Also known as smart arrays.
// The indexed value can be set or retrieved without explicitly specifying a type or instance memeber.
// We use "this" keywords to create a indexers.


// Observation for a:
// In program of question no. a,;  we can observe that we use get and set to get the requested indexed value and set the value to the index respectively.
// here the the data is set and fetched from the key which is an integer meaning the integer number is used to index the data

class IntType
{
    private string[] data;

    public IntType(int size)
    {
        data = new string[size];
    }
    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < data.Length)
                return data[index];
            else
                throw new IndexOutOfRangeException();
        }
        set
        {
            if (index >= 0 && index < data.Length)
                data[index] = value;
            else
                throw new IndexOutOfRangeException();
        }
    }
}

// class Program
// {
//     static void Main(string[] args){
//         IntType collection = new IntType(5);

//         // setting data using indexer
//         for(int i = 0; i< 5; i++){
//             collection[i] = "Value " + i;
//         }

//         for(int i = 0; i< 5; i++){
//             Console.WriteLine(collection[i]);
//         }
//     }
// }