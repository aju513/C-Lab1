using System;


// copy below code to program.cs
// class Program
// {
//     static void Main(string[] args){
//         Console.WriteLine("Enter some text (Press 'Enter' Twice to finish)");

//         string inputText = "";
//         while(true){
//             string? line = Console.ReadLine();
//             if(line == "")
//                 break;
//             inputText += line + Environment.NewLine;
//         }

//         Console.WriteLine("Enter the filename to save the text: ");
//         string? fileName = Console.ReadLine();

//         try{
//             File.WriteAllText($"./{fileName}", inputText);
//             Console.WriteLine($"Text successfully written to {fileName}");
//         }catch(Exception ex){
//             Console.WriteLine($"Error writing to file: {ex.Message}");
//         }
//     }
// }