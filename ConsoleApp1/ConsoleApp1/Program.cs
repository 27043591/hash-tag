using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".....Dictionaries......");

            Dictionary<int, string> dict = new Dictionary<int, string>();
            string input;
            for (int x = 1; x < 5; x++)
            {
                Console.WriteLine("write number");
                input = Console.ReadLine();
                dict.Add(x, input);
            }
            foreach(KeyValuePair<int,string> x in dict)
            {
                Console.WriteLine("\n\tkey: " + x.Key + "\tValue: " + x.Value);
            }
            Console.ReadLine();    
            
        }
    }
}

