using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            //1, 2.
            List<Book> books = new List<Book>
             {
                 new Book
                 {
                     Name="Гарри Поттер и узник Азкабана",
                     Cost=2243,
                     Author="Дж. К. Роулинг",
                     Year="2017"
                 },
                 new Book
                 {
                     Name="Зеленая миля",
                     Cost =1062,
                     Author="Стивен Кинг",
                     Year="2017"
                 },
                 new Book
                 {
                     Name="Унесенные ветром",
                     Cost=1750,
                     Author="Маргарет Митчелл",
                     Year ="2007"
                 }
             };
             var serializer = new BinaryFormatter();
             using (var stream = File.Create("file.bin"))
             {
                 serializer.Serialize(stream, books);
             }
             using (var stream = File.OpenRead("file.bin"))
             {
                 List<Book> result = (List<Book>)serializer.Deserialize(stream);
             }
             
        }
    }
}
