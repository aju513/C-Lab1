using System;

namespace NccLabAju
{
    using System;

    // Generic class definition
    public class GenericClass<T>
    {
        // Generic field
        private T genericField;

        // Constructor
        public GenericClass(T value)
        {
            genericField = value;
        }

        // Generic method
        public void DisplayValue()
        {
            Console.WriteLine("Value: " + genericField);
        }

        public void UpdateValue(T newValue)
        {
            genericField = newValue;
            Console.WriteLine("Value updated to: " + genericField);
        }
    }

    // static void Main()
    // {
    //     
    //     GenericClass<int> intObject = new GenericClass<int>(10);
    //     intObject.DisplayValue();  
    //     intObject.UpdateValue(20);  
    //     intObject.DisplayValue();  

    //      
    //     GenericClass<string> stringObject = new GenericClass<string>("Hello");
    //     stringObject.DisplayValue();  
    //     stringObject.UpdateValue("World");  
    //     stringObject.DisplayValue();  
    // }
}
