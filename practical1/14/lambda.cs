using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NccLabAju
{
    public delegate int SquareDelegate(int num);
    public delegate void HelloDelegate(string name);

    class LambdaDemo
    {
        public void lambdademo()
        {
            LambdaDemo ld = new LambdaDemo();

            HelloDelegate hd = (name) =>
            {
                string msg = "Hello " + name + " Good morning !";
                Console.WriteLine(msg);
            };
            //expression lamda
            SquareDelegate sd = (num) => num * num;
            hd("Avinash");
            int sqr = sd(7);
            Console.WriteLine("Square of 7 is " + sqr);
        }
    }
}
//    static void Main()
//     {
//         LambdaDemo temp = new LambdaDemo();
//         temp.lambdademo();
//     }
