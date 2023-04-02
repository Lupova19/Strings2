using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenzura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vavedi opredelena duma:");
            string word = Console.ReadLine();
            Console.Write("Vavedi izrecenie:");
            string sentense = Console.ReadLine();

            sentense = sentense.Replace(word , new string('*', word.Length));

            Console.WriteLine(sentense);
        }
    }
}
