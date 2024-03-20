using System;

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