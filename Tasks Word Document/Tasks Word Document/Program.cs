using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
            //Console.WriteLine("Bitte gib mir eine Texteingabe");
            //string text = Console.ReadLine();
            //Console.WriteLine(text.Contains("abc"));
            //Console.ReadKey();

            //Seite 1, Aufgabe 10: Frage den Nutzer nach einer Texteingabe und gebe den Text in kompletten groß bzw. kompletten Kleinbuchstaben aus
            //Console.WriteLine("Bitte gib mir eine Texteingabe");
            //string text = Console.ReadLine();
            //Console.WriteLine(text.ToUpper());
            //Console.ReadKey();

            //Seite 2, Aufgabe1: Programm frägt den Nutzer nach einer Zahl z.B. 20
            //int zahl = 0;
            //for (int i = 0; i <= 20; i++)
            //{ 
            //    zahl = i + zahl;
            //    Console.WriteLine(zahl);
            //}
            //Console.ReadKey();

            //Seite 2, Aufgabe 2: Frage nach einer Zahl und zähle von dieser Rückwärts bis 0
            //Console.WriteLine("Gib mir eine Zahl");
            //int zahl = Convert.ToInt32(Console.ReadLine());
            //for (int i = zahl; 0 < zahl; i++)
            //{
            //    zahl = zahl - 1;
            //    Console.WriteLine(zahl);
            //}
            //Console.ReadKey();

            //Seite 2, Aufgabe 3: Laufe mit einer For-Schleife über die Namen der Azubis & Studenten. Wenn der Name des Azubis ein „e“ enthält, gebe den Namen aus, 
            //ansonsten nicht. Wiederhole das Ganze und lass den Nutzer einen Buchstaben bestimmen, nach dem gesucht wird.
            //Console.WriteLine("Nach welchem Buchstaben möchtest du suchen?");
            //string search = Console.ReadLine();
            ////string[$"Jan{,} Erwin{,} Lukas{,} Jonas{,} Marcello{,} Mona{,} Philipp{,} Leon{,} Robert{,} Robin{,} Hannes"]
            //string[] namen = { "Jan", "Erwin", "Lukas", "Jonas", "Marcello", "Mona", "Philipp", "Leon", "Robert", "Robin", "Hannes" };
            ////string[] fzu = { $"Jan{,} Erwin{,} Lukas{,} Jonas{,} Marcello{,} Mona{,} Philipp{,} Leon{,} Robert{,} Robin{,} Hannes" };
            //for (int i = 0; i < namen.Length; i++)
            //{
            //    if (namen[i].Contains(search))
            //    {
            //        Console.WriteLine(namen[i]);
            //    }
            //}
            //Console.ReadKey();

            //Aufgabe 4: Frage den Nutzer  wie viele Einträge er in einem int-Array haben möchte.
            //Initialisiere ein int-Array von dieser Größe und befülle dieses Int Array in einer Schleife,
            //indem du den Nutzer jedes Mal frägst, welche Zahl eingetragen werden soll.  => Gebe anschließend alle Zahlen nacheinander nochmal aus

            //Console.WriteLine("Wie viele Einträge möchtest du in dein int Array?");
            //int anzahl = Convert.ToInt32(Console.ReadLine());
            //int[] zahlen = new int [anzahl];
            //for (int i = 0; i < zahlen.Length; i++)
            //{
            //    Console.WriteLine("Welche Zahl möchtest du hinzufügen");
            //    zahlen [i] = Convert.ToInt32(Console.ReadLine());
            //}
            //foreach (var e in zahlen)
            //{
            //    Console.WriteLine(e);
            //}
            //Console.ReadKey();

            //Aufgabe 4b) Gehe das Int - array durch und gebe den Maximal - Wert aus, Minimal - Wert und den Durchschnitt.
            Console.WriteLine("Wie viele Einträge möchtest du in dein int Array?");
            int anzahl = Convert.ToInt32(Console.ReadLine());
            int[] zahlen = new int[anzahl];
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine("Welche Zahl möchtest du hinzufügen");
                zahlen[i] = Convert.ToInt32(Console.ReadLine());
            }
            double durchschnitt = zahlen.Average();
            int höchstzahl = zahlen.Max();
            int kleinstzahl = zahlen.Min();
            Console.WriteLine($"Durchschnitt {durchschnitt}");
            Console.WriteLine($"Höchstwert {höchstzahl}");
            Console.WriteLine($"Kleinstzahl {kleinstzahl}");
            Console.ReadKey();

        }

    }
}
