using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication1
{
    class Item
    {
        string name;
        string country;
        Int32 number;
        Double value;
        public Item(string n, string  c, Int32 num, Double v)
        {
            name = n;
            country = c;
            number = num;
            value = v;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", name, country, number, value);
        }
    }
    class Program
    {
        static List<Item> product = new List<Item>();

        static void ParseDocument(string content)
        {
            int pos = 0;

            while ((pos = content.IndexOf("<item>", pos) + 1) <= content.Length)
            {
                pos = content.IndexOf("<name", pos);
                pos = content.IndexOf(">", pos) + 1;
                int p = content.IndexOf("</name>", pos);
                string name = content.Substring(pos, p - pos);

                pos = content.IndexOf("<country", pos);
                pos = content.IndexOf(">", pos) + 1;
                p = content.IndexOf("</country>", pos);
                string country = content.Substring(pos, p - pos);

                pos = content.IndexOf("<number", pos);
                pos = content.IndexOf(">", pos) + 1;
                int num = int.Parse(content.Substring(pos, content.IndexOf("</number>", pos) - pos));

                pos = content.IndexOf("<value", pos);
                pos = content.IndexOf(">", pos) + 1;
                int value = int.Parse(content.Substring(pos, content.IndexOf("</value>", pos) - pos));


                product.Add(new Item(name, country, num, value));
                if (content.IndexOf("<item>", pos) < pos)
                    break;
            }
        }

        static void Main(string[] args)
        {
            FileStream file = new FileStream("file.xml", FileMode.Open, FileAccess.Read);

            StreamReader reader = new StreamReader(file);

            string content = reader.ReadToEnd();

            ParseDocument(content);

            foreach (Item s in product)
            {
                Console.WriteLine(s);
            }

            file.Close();
        }
    }
}