using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    public class UserAttribute:System.Attribute
    {
        public string Name { get; set; }
        public double Version { get; set; }
        public UserAttribute(string name)
        {
            Name = name;
            Version = 1.0;
        }
    }
}
