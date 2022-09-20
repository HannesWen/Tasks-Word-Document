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
            //Console.WriteLine("Welche 2 Zahlen möchtest du summieren?");
            //int zahl1 = Convert.ToInt32(Console.ReadLine());
            //int zahl2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Die Summe der beiden Zahlen ist {zahl1 + zahl2}");
            //Console.ReadKey();

            //Seite 1, Aufgabe 3: Frage den Nutzer nach einem Text und ersetze im Text alle vorkommenden „U“ und „u“ durch „G“ und „g“
            //Console.WriteLine("bitte gib mir einen Text");
            //string text = Console.ReadLine();
            //string replaced_text = text.Replace("U", "u").Replace("G", "g");
            //Console.Write($"Dein neuer Text lautet {replaced_text}");
            //Console.ReadKey();

            //Seite 1, Aufgabe 4: Frage den Nutzer nach einem Text und gebe die Länge des eingegebenen Textes aus z.B. „Die Länge des eingegebenen Texts ist 7“
            //Console.WriteLine("Bitte gib mir einen Text");
            //string textlaenge = Console.ReadLine();
            //Console.WriteLine($"Die länge deines textes ist: {textlaenge.Length}");
            //Console.ReadKey();

            //Seite 1, Aufgabe 2b: Frage den Nutzer nach zwei Fließkommazahlen und addiere diese
            //Console.WriteLine("Bitte gib mir zwei Kommazahlen");
            //float zahl1 = float.Parse(Console.ReadLine());
            //float zahl2 = float.Parse(Console.ReadLine());
            //Console.WriteLine($"Die Summe deiner Zahlen ist {zahl1 + zahl2}");
            //Console.ReadKey();

            //Seite 1, Aufgabe 5: Frage den Nutzer nach einer Texteingabe und fülle diese mit bis zu 20 Stellen mit einem y von links auf
            //Console.WriteLine("Bitte gib mir eine Texteingabe");
            //string texteingabe = Console.ReadLine();
            //Console.WriteLine($"Dein neuer Text ist {texteingabe.PadLeft(20, 'y')}");
            //Console.ReadKey();

            //Seite 1, Aufgabe 6: Frage den Nutzer nach einer Texteingabe und fülle diese mit bis zu 30 Stellen mit einem y von rechts auf und gebe den veränderten Text wieder aus
            //Console.WriteLine("Bitte gib mir einen Text");
            //string texteingabe = Console.ReadLine();
            //Console.WriteLine($"Dein neuer Text ist {texteingabe.PadRight(30, 'y')}");
            //Console.ReadKey();


            //Seite 1, Aufgabe 7: Frage den Nutzer nach einer Texteingabe ( es sollen davor und danach Leerzeilen sein) und gebe die Eingabe ohne Leerzeichen wieder aus 
            //Console.WriteLine("Gib mir einen Text und lasse davor einige leerzeichen");
            //string texteingabe = Console.ReadLine();
            //Console.WriteLine($"Dein Text ohne leerzeichen: {texteingabe.Trim()}");
            //Console.ReadKey();

            //Seite 1, o Aufgabe 8: Frage den Nutzer nach einer Eingabe mit Semikolons( ; ) und Splitte die Eingabe an diesem Zeichen.Gebe die einzelnen Werte auf der Console aus.
            //Console.WriteLine("Gebe mir eine Eingabe mit ; ");
            //string text = Console.ReadLine();
            //string[] words = text.Split(';');
            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}
            //Console.ReadKey();

            //Seite 1, Aufgabe 9: Frage den Nutzer nach einer Eingabe und überprüfe die Texteingabe des Nutzers, ob die Zeichen „abc“ in der Eingabe enthalten sind. Gebe true oder false auf der Konsole aus. 
            Console.WriteLine("Bitte gib mir eine Texteingabe");
            string text = Console.ReadLine();
            Console.WriteLine(text.Contains("abc"));
            Console.ReadKey();


        }
    }
}
