using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace XMLReader
{
    class Program
    {
        //https://www.dotnetcurry.com/linq/564/linq-to-xml-tutorials-examples

        static void Main(string[] args)
        {

            //Instanz erzeugen 
            //XDocument xml = null;            
            //xml = ReadXMLDocumentFirst();

            //eine Instanz erzeugen und den Pfad angeben dieser befindet sich im bin Ordner des Orojektes 

            XElement xelement = XElement.Load(@"Employees.xml");

            //Aufruf der Klasse und eine Objekt erzeugen 
            //ReadXMLFile c = new ReadXMLFile();
            //c.ReadXMLFileAndGiveInConsole(xelement);

            //ReadNameTagAndGiveValue(xelement);

            ProvideTheTagsWithTheNameFemale(xelement);

            Console.ReadKey();
        }

        private static void ProvideTheTagsWithTheNameFemale(XElement xelement)
        {
            //Liefert mir alle Employee die das Element "Sex" haben und ihr Inhalt Fenale ist. 
            IEnumerable<XElement> name = from nm in xelement.Elements("Employee")
                                         where (string)nm.Element("Sex") == "Female"
                                         select nm;
            Console.WriteLine("Details of Female Employees:");

            foreach (XElement xEle in name)
                Console.WriteLine(xEle); //Liefert mir alle ein XML
                                         //Console.WriteLine(xEle.Value); Liefert mir alle inhalte der Tags
        }

        private static void ReadNameTagAndGiveValue(XElement xelement)
        {
            IEnumerable<XElement> employees = xelement.Elements();
            Console.WriteLine("Liste aller Elemente die einen Namen Tag haben und Ihren Inhalt:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Element("Name").Value);
            }
            Console.WriteLine();
        }

        private static XDocument ReadXMLDocumentFirst()
        {
            //Lesen eines XML Document und auf der Konsole ausgeben
            XDocument xml;
            using (XmlReader xmlRead = XmlReader.Create("books.Xml"))
            {
                xml = XDocument.Load(xmlRead);
            }
            Console.Write(xml.ToString());
            return xml;
        }
    }
}

