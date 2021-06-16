using System;
using System.Xml.XPath;

namespace task3
{
    internal static class Program
    {
        private static void Main()
        {
            var xPathDocument = new XPathDocument("../../../TelephoneBook.xml");
            var xPathNavigator = xPathDocument.CreateNavigator();
            if (xPathNavigator == null) return;
            var xPathNodeIterator = xPathNavigator.Select("MyContacts/Contact/TelephoneNumber");
            foreach (var item in xPathNodeIterator)
            {
                Console.WriteLine(item);
            }
        }
    }
}