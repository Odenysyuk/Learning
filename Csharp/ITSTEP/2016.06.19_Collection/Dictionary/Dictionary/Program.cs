using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> dict = new Dictionary<string, string>();
            dict.Add("і", "and");

            foreach (String el in dict.Keys)
            {
                Console.WriteLine("{0}:{1}", el, dict[el]);
            }
        }

        static Dictionary<String, String> AddText(Dictionary <String, String> dict, String Sentence)
        {
            Sentence.

            return dict;
        }
    }
}
