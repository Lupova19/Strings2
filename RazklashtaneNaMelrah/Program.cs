using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazklashtaneNaMelrah
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string findString = Console.ReadLine();
            string output = input;
            int counter = 0;
            while (output.Contains(findString)) 
            {  
                counter++;
                int pos = output.IndexOf(findString);
                int len = findString.Length;
                output = output.Remove(pos, len);
            }if (counter >= 0)
            {
                Console.WriteLine("Shaked it!");
            }else
            {
                Console.WriteLine("No shake!");
            }
            Console.WriteLine($"InputString = {input}");
            Console.WriteLine($"OutputString = {output}");
        }
    }
}
