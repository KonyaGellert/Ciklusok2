using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGciklusok2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Kérem az 1. számot: ");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a 2. számot: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());

            if (szam1 < szam2)
            {
                Console.WriteLine($"A második szám a nagyobb({szam2}) és a különbsége {szam2 - szam1} ");
            }
            else
            {
                Console.WriteLine($"Az első szám a nagyobb({szam1}) és a különbsége {szam1 - szam2} ");
            }

            Console.WriteLine("--------------------------------------------------");

            //2
            Console.WriteLine("Adj meg egy számot");
            int szam = int.Parse(Console.ReadLine());
            List<int> szamok = new List<int>();

            while (szam != 0)
            {
                szamok.Add(szam);
                Console.WriteLine("Adj meg egy számot");
                szam = int.Parse(Console.ReadLine());
            }

            if (szamok.Count == 0)
            {
                Console.WriteLine("Nem adtál meg számot.");
                return;
            }

            int legtobbSzam = szamok[0];
            int legtobbDarab = 1;

            for (int i = 0; i < szamok.Count; i++)
            {
                int szamlalo = 1;
                for (int j = i + 1; j < szamok.Count; j++)
                {
                    if (szamok[i] == szamok[j])
                        szamlalo++;
                }
                if (szamlalo > legtobbDarab)
                {
                    legtobbDarab = szamlalo;
                    legtobbSzam = szamok[i];
                }
            }

            Console.WriteLine($"A legtöbbször megadott szám: {legtobbSzam} ({legtobbDarab} alkalommal)");





















        }
    }
}
