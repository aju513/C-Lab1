using System;

namespace NccLabAju
{
    public class MyClass
    {
        // Auto-property
        public string AutoProperty { get; set; }

        // Read-only property
        public string ReadOnlyProperty { get; }

        // Constructor to initialize read-only property
        public MyClass(string readOnlyValue)
        {
            ReadOnlyProperty = readOnlyValue;
        }
    }
}
