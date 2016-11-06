using System;
using System.Text;
using System.Xml;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteXML();
            ReadXML();
        }

        static void WriteXML() {
            XmlTextWriter writer = new XmlTextWriter("orders.xml", Encoding.UTF8);

            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();

            writer.WriteStartElement("buylist");
            writer.WriteStartElement("item");
            writer.WriteElementString("name", "Apple");
            writer.WriteElementString("Data", "10072016");
            writer.WriteElementString("Telephone", "1111");
            writer.WriteElementString("Info", "Order1");
            writer.WriteEndElement();
            writer.WriteStartElement("buylist");
            writer.WriteStartElement("item");
            writer.WriteElementString("name", "Orange");
            writer.WriteElementString("Data", "10072016");
            writer.WriteElementString("Telephone", "2222");
            writer.WriteElementString("Info", "Order1");
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.Close();
        }

        static void ReadXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("orders.xml");
            ShowElement(doc.DocumentElement);
        }

        static void ShowElement(XmlNode node, int i = 0)
        {
            for (int j = 0; j < i; ++j)
            {
                Console.Write("\t");
            }
            Console.WriteLine("Name: {0}\tType: {1}\tValue: {2}", node.Name, node.NodeType, node.Value);
            if (node.Attributes != null)
            {
                foreach (XmlAttribute attr in node.Attributes)
                {
                    for (int j = 0; j < i; ++j)
                    {
                        Console.Write("\t");
                    }
                    Console.WriteLine("Attrib: {0}\tType: {1}\tValue: {2}", attr.Name, attr.NodeType, attr.Value);
                }
            }
            if (node.HasChildNodes)
            {
                XmlNodeList children = node.ChildNodes;
                foreach (XmlNode n in children)
                {
                    ShowElement(n, i + 1);
                }
            }
        }
    }
}