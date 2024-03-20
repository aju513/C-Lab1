using System;

namespace NccLabAju
{
    public class PropertyDemo
    {
        public string _name = "Aju maharjan";
        public string Name
        {
            get
            {
                return _name.ToUpper(); //converting to upper case
            }
            set { _name = value; }
        }
    }
}
//   PropertyDemo pd = new PropertyDemo();
//     string fullName = pd.Name;
//     Console.WriteLine("Hello " + fullName + "\n");

//     pd.Name = "Using Set Property";
//     Console.WriteLine(pd._name);
//     Console.WriteLine("Lab No:1");
//     Console.WriteLine("Name:Aju Maharjan");
//     Console.WriteLine("Roll no:38,Section:B");
