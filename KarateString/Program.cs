using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KarateString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string niz = Console.ReadLine();
            int strenght = 0;

            for (int i = 0; i < niz.Length; i++)
            {
               if (niz[i] == '>') 
                { 
                    strenght += strenght = int.Parse(niz[i + 1].ToString());
                }
                else if (strenght > 0) 
                {
                    niz = niz.Remove(i , 1); 
                    i--;
                    strenght--;
                }
            }
            Console.WriteLine(niz);
        }
    }
}
