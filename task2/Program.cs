using System;
using System.Xml;

namespace task2
{
    internal static class Program
    {
        private static void Main()
        {
            var document = new XmlDocument();
            document.Load("../../../TelephoneBook.xml");
            Console.WriteLine(document.Name);
            Console.WriteLine(document.InnerText);
            Console.WriteLine(document.InnerXml);
            Console.WriteLine(document.IsReadOnly);
        }
    }
}