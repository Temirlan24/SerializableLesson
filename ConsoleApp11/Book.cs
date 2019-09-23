using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace ConsoleApp11
{
    [Serializable]
    public class Book
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }
    }
}
