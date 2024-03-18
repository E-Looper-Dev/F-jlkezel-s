using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace Fajlkezeles
{
    internal class Program
    {
        static List<string> sutik = new List<string>();
        static List<string> muffin = new List<string>();
        static List<string> acmLista = new List<string>();
        static List<string> ForditottLista = new List<string>();
        static void Sutik()
        {
            StreamReader olvasas = new StreamReader("sutik.txt");
            while (!olvasas.EndOfStream)
            {
                sutik.Add(olvasas.ReadLine());
            }
            foreach (var item in sutik)
            {
                Console.WriteLine(item);
            }
            olvasas.Close();
        }
        static void Szamlal()
        {
            Console.WriteLine($"{sutik.Count} süti van a rendszerben." );
        }
        static void LegHosszabb()
        {
            string hosszu = sutik[0];
            foreach (var item in sutik)
            {
                if (hosszu.Length < item.Length)
                {
                    hosszu = item;
                }
            }
            Console.WriteLine($"A leghosszabb szó a listában: {hosszu}.");
        }
        static void Csoki()
        {
            int darab = 0;
            foreach (var item in sutik)
            {
                if (item.Contains("csoki"))
                {
                    darab++;
                }
            }
            Console.WriteLine($"{darab} db süti nevében szerepel a csoki szó.");
        }
        static void Sorrend()
        {
            sutik.Sort();
            foreach (var item in sutik)
            {
                Console.WriteLine(item);
            }
        }
        static void Muffin()
        {
            foreach (var item in sutik)
            {
                if (item.Contains("muffin"))
                {
                    muffin.Add(item);
                }
            }
            foreach (var item in muffin)
            {
                Console.WriteLine(item);
            }
        }
        static void ellenorzes()
        {
            foreach (var item in sutik)
            {
                if (item == "mogyorókrémes linzer")
                {
                    Console.WriteLine("Igen, megtalálható a listában.");
                }
                else
                {
                    Console.WriteLine("Nem nyert.");
                }
            }
        }
        static void acm()
        {
            foreach (var item in sutik)
            {
                if (item.StartsWith("a") || item.StartsWith("c") || item.StartsWith("m"))
                {
                    acmLista.Add(item);
                }
            }
        }
        static void Kaloria()
        {
            double osszesKaloria = sutik.Count * 120 * 2;
            Console.WriteLine($"Az összes kalória a listában szereplő sütemények esetén: {osszesKaloria}");
        }
        static void Paros()
        {
            for (int i = 0; i < sutik.Count; i += 2)
            {
                Console.WriteLine("Index " + i + ": " + sutik[i]);
            }
        } 
        static void Forditott()
        {
            foreach (var item in sutik)
            {
                char[] karakterek = item.ToCharArray();
                Array.Reverse(karakterek);
                string megforditottSuti = new string(karakterek);
                ForditottLista.Add(megforditottSuti);
            }
            Console.WriteLine("A fordított lista tagjai: ");
            foreach (var item in ForditottLista)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            Sutik();
            //Szamlal();
            //LegHosszabb();
            //Csoki();
            //Sorrend();
            //Muffin();
            //ellenorzes();
            //acm();
            //Kaloria();
            //Paros();
            Forditott();
        }
    }
}
