using System;
using System.Collections.Generic;

namespace Ueb08d_Sortieren_Fruechte
{
    /// <summary>
    /// Uebung 08d Sortieren von Fruechten
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Birnen und Äpfel vergleichen");

            List<Frucht> fruechte = new List<Frucht>();

            fruechte.Add(new Birne { Preis = 1.25f });
            fruechte.Add(new Birne { Preis = 0.95f });
            fruechte.Add(new Apfel { Preis = 0.8f });
            fruechte.Add(new Apfel { Preis = 0.9f });
            fruechte.Add(new Birne { Preis = 1.1f });
            fruechte.Add(new Birne { Preis = 1.0f });

            foreach (var f in fruechte)
            {
                // Name und Preis anzeigen
                Console.WriteLine(f.GetType().Name + " " + f.Preis);
            }

            // Sortieren
            fruechte.Sort(new PreisComparer());
            Console.WriteLine("");

            foreach (var f in fruechte)
            {
                // Name und Preis anzeigen
                Console.WriteLine(f.GetType().Name + " " + f.Preis);
            }
        }
    }
}