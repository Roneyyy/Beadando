using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem a beküldendö számok mennyiségét: ");
            string darab = Console.ReadLine();
            int db;
            bool szame = false;
            do
            {
                if (int.TryParse(darab, out db))
                {
                    szame = true;
                }
                else
                {
                    Console.Write("Kérem számot adjon meg: ");
                }
            } while (szame==false);
            int[] szamok = new int[db];
            for (int i = 0; i < szamok.Length;)
            {
                szame = false;
                int szam;
                do
                {
                    Console.Write("Kérem adja meg a(z) {0}. számot: ", i + 1);
                    string beker = Console.ReadLine();
                    if (int.TryParse(beker, out szam))
                    {
                        szame = true;
                        szamok[i] = szam;
                        
                    }
                    else
                    {
                        Console.Write("Kérem számot adjon meg: ");
                    }
                } while (szame == false);
                i++;
            }
            Console.WriteLine("A legkisebb szám: "+szamok.Min());
            Console.WriteLine("A legnagyobb szám: "+szamok.Max());
            Console.ReadLine();

        }
    }
}
