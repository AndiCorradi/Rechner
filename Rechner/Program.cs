using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Rechner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hole Summanden
            Console.Write("Bitte gib den ersten Summanden ein: ");
            string ersterSummand = Console.ReadLine();
            Console.Write("Bitte gib den zweiten Summanden ein: ");
            string zweiterSummand = Console.ReadLine();

            // convertieren in Gleitkommazhlen

            double ersterSummandAlsZahl = Convert.ToSingle(ersterSummand);
            double zweiterSummandAlsZahl = Convert.ToSingle(zweiterSummand);

            // Berechnung ausführen

            double summe = ersterSummandAlsZahl + zweiterSummandAlsZahl;

            // Ausgabe
            Console.WriteLine("Die Summe ist: {0}", summe);
            Console.WriteLine("Drücke den AnyKey um das Programm zu schliessen");
            Console.ReadLine();
        }
    }
}
