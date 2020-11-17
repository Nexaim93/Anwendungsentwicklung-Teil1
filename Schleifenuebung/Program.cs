using System;
using System.Collections.Generic;

namespace Schleifenuebung
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wortschleife();
            for (int i = 0; i < 20; i++)
            {
                List<int> Liste1 = new List<int>();
                List<int> Liste2 = new List<int>();

                EuroJackpot(Liste1, Liste2);
                PrintLotto(Liste1, Liste2);
            }
        }
        static void PrintLotto(List<int> Numbers, List<int> Special)
        {
            Console.Write("EuroJackpot Zahlen:");
            foreach (var item in Numbers)
            {
                Console.Write("{0,3}", item);
            }
            Console.Write(" Zusatz:");
            foreach (var item in Special)
            {
                Console.Write("{0,3}", item);
            }
            Console.WriteLine();
        }
        static void EuroJackpot(List<int> Numbers, List<int> Special)
        {

            //Eurojackpot
            // 5x 1 - 50 
            // 2x 1 - 10
            Random rndGen = new Random();
            while (Numbers.Count < 5)
            {
                int newNumber = rndGen.Next(1, 51);
                bool insertAllowed = true;

                foreach (var item in Numbers)
                {
                    if (item == newNumber)
                    {
                        insertAllowed = false;
                        break;
                    }
                }

                if (insertAllowed)
                {
                    Numbers.Add(newNumber);
                }

            }

            while (Special.Count < 2)
            {
                int newNumber = rndGen.Next(1, 11);
                bool insertAllowed = true;

                foreach (var item in Special)
                {
                    if (item == newNumber)
                    {
                        insertAllowed = false;
                        break;
                    }
                }

                if (insertAllowed)
                {
                    Special.Add(newNumber);
                }
            }

            // solange weniger als 5 zahlen in der Liste
            // neue Zahl ziehen
            // eintrageerlaubnis auf ja setzen
            // durch bestehende liste durchlaufen
            // wenn gezogene mit bestehenden identisch
            // wenn eine identisch, eintrageerlaubnis auf nein
            // ende wenn
            // ende listendurchlauf
            // wenn eintrageerlaubnis auf ja
            // gezogene zahl an liste anfügen
            // ende wenn
            // ende solange


            /*
            Console.Write("Lottozahlen: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(rndGen.Next(1,51) + " "); // Zufallsgenerator mit den Zahlen zwischen 1 - 50 ( Minimumwert EXAKT / Maximumwert -1 ) ODER rndGen.Next(50)+1
            }
            Console.Write("\nZusatzzahlen: ");
            for (int i = 0; i < 2; i++)
            {
                Console.Write(rndGen.Next(1,11) + " ");
            }
            */

        }
        static void Wortschleife()
        {
            string text = "Hello World";
            Console.WriteLine(text);

            for (int i = 0; i < text.Length; i++) // Zählerschleife von 0 solange textende nicht erreicht
            {
                Console.Write(text[i]); // ausgabe des buchstabens an der stelle des zählers.
            }
            Console.WriteLine("");

            for (int i = text.Length - 1; i >= 0; i--) // text buchstabe für buchstabe ausgeben, diesmal aber rückwärts
            {
                Console.Write(text[i]);
            }
            Console.WriteLine("");
            for (int i = 0; i < text.Length; i += 2) // text ausgeben, aber nur jeden zweiten buchstaben
            {
                Console.Write(text[i]);
            }
            Console.WriteLine("");
            Console.Write(text[0]); // Da die schleife nicht bei 0 anfangen kann wenn multipliziert wird muss es so ausgegeben werden!
            for (int i = 1; i < text.Length; i *= 2) // text ausgeben, aber zähler immer verdoppeln // i muss bei 1 Anfangen (0 kann nicht verdoppelt werden)
            {
                Console.Write(text[i]);
            }
            Console.WriteLine("");
            Random rndGen = new Random(); // Random Generator !

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[rndGen.Next(text.Length)]); // Zufällige Buchstaben aus de Länge und Inhaltes des Textes generieren!
            }
            Console.ReadLine();
        }
    }
}
