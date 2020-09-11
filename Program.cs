using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozasi_tetelek
{
    class Program
    {
        static int[] tomb = new int[] { 12, 7, 4, 2, 45, 99, 1, 8, 95, 50  };
        static void Main(string[] args)
        {
            TombKiiras();
            osszegzes();
            megszamolas();
            Console.ReadKey();
        }

        private static void megszamolas()
        {
            int s = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 3 == 0)
                {
                    s++;
                }
            }
            Console.WriteLine("A tömbben {0} \"-3 al\" osztható szám van", s);
        }

        private static void osszegzes()
        {
            int s = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                s = s + tomb[i];
            }
            Console.WriteLine("");
            Console.WriteLine("A tömb elemeinek összege: {0}", s);
        }

        private static void TombKiiras()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i]+",");
            } 
        }
    }
}
