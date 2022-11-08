

using System;

namespace Uebung01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Schreiben Sie ein Programm, das zwei Zahlen einliest und anschließend mit Hilfe
             einer Switch-Anweisung ein Menü anbietet, in welchem der Benutzer zwischen
             den 4 Grundrechnungsarten wählen kann. Inkludieren Sie einen Menüpunkt für
             einen Abbruch des Programmes.

             Nach entsprechender Wahl soll der Anwender das Ergebnis (wenn mathematisch möglich)
             ausgegeben bekommen.

             Nach der Ausgabe der Berechnung soll das Programm automatisch von neuem starten.
             */

            // Variablen
            int zahl1, zahl2, ergebnis;
            string wahl;

            // Eingabe
            Console.WriteLine("Bitte geben sie 2 Zahlen ein: ");
            Console.WriteLine("Zahl 1: ");
            zahl1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Zahl 2: ");
            zahl2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Wählen sie eine Grundrechenart: ");
            Console.WriteLine(" 1. + Addition");
            Console.WriteLine(" 2. - Subtraktion");
            Console.WriteLine(" 3. * Multiplikation");
            Console.WriteLine(" 4. / Division");
            Console.WriteLine(" 5. x Abbruch");
            Console.WriteLine();
            Console.Write("Deine Wahl: ");
            wahl = Console.ReadLine();

            switch (wahl)
            {
                case "1":
                case "+":
                    {
                        ergebnis = zahl1 + zahl2;
                        Console.WriteLine();
                        Console.WriteLine($"Das Ergebnis lautet: " + ergebnis);
                        Console.WriteLine("'Enter' um fortzufahren");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }

                case "2":
                case "-":
                    {
                        ergebnis = zahl1 - zahl2;
                        Console.WriteLine();
                        Console.WriteLine($"Das Ergebnis lautet: " + ergebnis);
                        Console.WriteLine("'Enter' um fortzufahren");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }

                case "3":
                case "*":
                    {
                        ergebnis = zahl1 * zahl2;
                        Console.WriteLine();
                        Console.WriteLine($"Das Ergebnis lautet: " + ergebnis);
                        Console.WriteLine("'Enter' um fortzufahren");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }

                case "4":
                case "/":
                    {
                        ergebnis = zahl1 / zahl2;
                        Console.WriteLine();
                        Console.WriteLine($"Das Ergebnis lautet: " + ergebnis);
                        Console.WriteLine("'Enter' um fortzufahren");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case "5":
                case "x":
                    {
                        // Environment.Exit; Nachschauen
                        break;
                    }
            }

            // Berechnung


            // Ausgabe
        }
    }
}