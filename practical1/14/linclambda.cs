using System;
using System.Collections.Generic;
using System.Linq;

namespace NccLabAju
{
    class LincLambda
    {
        public void linclambda()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // LINQ query with lambda expression to filter even numbers
            var evenNumbers = numbers.Where(num => num % 2 == 0);

            Console.WriteLine("Even numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
