using System;

namespace NccLabAju
{
    public class PropertyDemo
    {
        public string _name ="Aju maharjan";
        public string Name
        {
            get
            {
                return _name.ToUpper(); //converting to upper case
            }
            set { 
                _name=value;
            }
        }
    }
}
