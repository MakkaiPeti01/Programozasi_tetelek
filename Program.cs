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
            eldontes();
            kivalasztas();
            kereses();
            maximum();
            Console.ReadKey();
        }

        private static void maximum()
        {
            int m = tomb[0];
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] > m)
                {
                    m = tomb[i];
                }
            }
            Console.WriteLine("A tömb legnagyobb eleme: {0}", m);
        }

        private static void kereses()
        {
            int s = 1;
            while (s <= tomb.Length && tomb[s] != 50)
            {
                s++;
            }
            if (s<=tomb.Length)
            {
                Console.WriteLine("A keresett elem a {0}. a tömbben", s + 1);
            }
            else
            {
                Console.WriteLine("Nincs a tömbben");
            }
        }

        private static void kivalasztas()
        {
            int s = 1;
            while (tomb[s] != 50)
            {
                s = s + 1;
            }
            Console.WriteLine("Az \"50\" es a {0}. helyen van",s+1);
        }

        private static void eldontes()
        {
            int s = 0;
            while (s<tomb.Length && tomb[s]!=69)
            {
                s++;
            }
            if (s < tomb.Length)
            {
                Console.WriteLine("Van 69");
            }
            else
            {
                Console.WriteLine("Nincs 69");
            }
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
