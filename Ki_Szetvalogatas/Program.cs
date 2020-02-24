using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ki_Szetvalogatas
{
    class Program
    {
        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
        }

        static void Feladat1()
        {
            Random rnd = new Random();
            Console.WriteLine("Elemszám?");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tomb = new int[n];

            int[] kivalogatottTomb = new int[n];

            int sum = 0;

            int j = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(-10, 151);
                if (tomb[i] % 3 == 0)
                {
                    kivalogatottTomb[j] = tomb[i];
                    sum += kivalogatottTomb[j];
                    j++;
                }
            }

            Console.WriteLine("Az eredeti tömb:");

            foreach (var item in tomb)
            {
                Console.WriteLine("{0} ", item);
            }

            Console.WriteLine("Kiválogatott tömb:");
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("{0} ", kivalogatottTomb[i]);
            }

            Console.WriteLine("\nA kiválogatott tömb átlaga: {0:0.00}", (double)sum / j);
            Console.WriteLine("Maximuma: {0}", kivalogatottTomb.Max());
            Console.WriteLine("Minimuma: {0}", kivalogatottTomb.Min());

            //rendezés:
            for (int i = 0; i < kivalogatottTomb.Length; i++)
            {

            }

            Console.ReadKey();
            Console.Clear();
        }

        static void Feladat2()
        {
            string[] nevek = new string[10];
            List<string> tartalmaz = new List<string>();
            List<string> nemTartalmaz = new List<string>();


            //Feltöltés
            for (int i = 0; i < nevek.Length; i++)
            {
                Console.WriteLine("Kérek még {0} db nevet!",10-i);
                nevek[i] = Console.ReadLine();
                if (nevek[i].ToUpper().Contains("A") || nevek[i].ToUpper().Contains("Á"))
                {
                    tartalmaz.Add(nevek[i]);
                }
                else
                    nemTartalmaz.Add(nevek[i]);
            }

            Console.WriteLine("\n'A/Á' betűket tartalmazó nevek listája:");
            foreach (var item in tartalmaz)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n'A/Á' betűket NEM tartalmazó nevek listája:");
            foreach (var item in nemTartalmaz)
            {
                Console.WriteLine(item);
            }

            //tartzalmaz tömb rendezése
            tartalmaz.Sort();
            nemTartalmaz.Sort();

            Console.WriteLine("\nRendezve:");

            foreach (var item in tartalmaz)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------");
            foreach (var item in nemTartalmaz)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
