using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KGciklusok2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.Write("Kérem az 1. számot: ");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem a 2. számot: ");
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
            Console.Write("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            List<int> szamok = new List<int>();

            while (szam != 0)
            {
                szamok.Add(szam);
                Console.Write("Adj meg egy számot: ");
                szam = int.Parse(Console.ReadLine());
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

            Console.WriteLine("--------------------------------------------------");

            //3
            List<int> paros = new List<int>();
            List<int> paratlan = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Kérem a számot: ");
                int szam3 = int.Parse(Console.ReadLine());
                if (szam3 % 2 == 0)
                {
                    paros.Add(szam3);
                }
                else
                {
                    paratlan.Add(szam3);
                }

            }


            Console.WriteLine($"Páros számokbol {paros.Count} db van");
            Console.WriteLine($"Páratlan számokbol {paratlan.Count} db van");

            Console.WriteLine("--------------------------------------------------");

            //4
            Console.Write("Kérek egy szót: ");
            string szo = Console.ReadLine();
            int otosszo = 0;
            while (szo != "vége")
            {
                Console.Write("Kérek egy szót: ");
                szo = Console.ReadLine();
                if (szo.Length > 5)
                {
                    otosszo++;
                }
            }
            Console.WriteLine($"5 karakternél hosszabb szavak száma: {otosszo}");


            Console.WriteLine("--------------------------------------------------");

            //5


            int osszeg = 0, darab = 0;
            int egyes = 0, kettes = 0, harmas = 0, negyes = 0, otos = 0;

            Console.Write("Osztályzat (1-5, -1 vége): ");
            int jegy = int.Parse(Console.ReadLine());

            while (jegy != -1)
            {
                if (jegy >= 1 && jegy <= 5)
                {
                    osszeg += jegy;
                    darab++;
                    if (jegy == 1) egyes++;
                    else if (jegy == 2) kettes++;
                    else if (jegy == 3) harmas++;
                    else if (jegy == 4) negyes++;
                    else otos++;
                }

                Console.Write("Osztályzat (1-5, -1 vége): ");
                jegy = int.Parse(Console.ReadLine());
            }

            if (darab > 0)
                Console.WriteLine($"Átlag: {(double)osszeg / darab:F2}");
            else
                Console.WriteLine("Nem adtál meg osztályzatot.");

            Console.WriteLine($"1-es: {egyes}, 2-es: {kettes}, 3-as: {harmas}, 4-es: {negyes}, 5-ös: {otos}");

            Console.WriteLine("--------------------------------------------------");

            //6










        }
    }
}
