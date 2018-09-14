using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace XMLReader
{
    internal class ReadXMLFile
    {
        public void ReadXMLFileAndGiveInConsole(XElement xelement)
        {
            IEnumerable<XElement> employees = xelement.Elements();
            // Read the entire XML
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
