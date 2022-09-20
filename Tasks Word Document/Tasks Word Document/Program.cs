using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_Word_Document
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Seite 1, Aufgabe 1: initialisiere 2 Zahlen und gebe die Summe der Zahlen auf der Console aus
            //int zahl1 = 1;
            //int zahl2 = 2;
            //Console.WriteLine($"Die Summe der Zahlen ist {zahl1 + zahl2}");
            //Console.ReadKey();

            //Seite 1, Aufgabe 2: Frage den Nutzer welche zwei Zahlen er addieren möchte und gebe am Ende das Ergebnis aus
            Console.WriteLine("Welche 2 Zahlen möchtest du summieren?");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            int zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Die Summe der beiden Zahlen ist {zahl1 + zahl2}");
            Console.ReadKey();


        }
    }
}
