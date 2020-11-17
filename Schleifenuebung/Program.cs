using System;
using System.Collections.Generic;

namespace Schleifenuebung
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wortschleife();


            /*for (int i = 0; i < 1; i++) //TODO: Schleife umbauen das sie 10 sekunden lang läuft (DateTime.Now)
            {
                List<byte> Liste1 = new List<byte>();
                List<byte> Liste2 = new List<byte>();

                EuroJackpot(Liste1, Liste2);
                PrintLotto(Liste1, Liste2);
            }*/

            //TODO: 1x Lottoergebnis ziehen (gegen das vergleichen wir unsere scheine)
            //TODO: Ergebnisarray der länge 8 erstellen.
            List<byte> Liste1 = new List<byte>(); // Liste für Numbers
            List<byte> Liste2 = new List<byte>(); // Liste für Special
            List<byte> MyNumbers = new List<byte>(); // Liste für MyNumbers
            List<byte> MySpecial = new List<byte>(); // Liste für MySpecial
            DateTime Startzeit = DateTime.Now; // Aktuelle SystemZeit Sichern !
            int[] Treffer = new int[8]; // erstelle Treffer mit einer Range von 8

            byte[] MeineLottoZahlen = { 5, 17, 21, 37, 38 };
            MyNumbers.AddRange(MeineLottoZahlen);

            byte[] MeineSpecialZahlen = { 1, 4 };
            MySpecial.AddRange(MeineSpecialZahlen);


            int Versuche = 0;
            while ((DateTime.Now - Startzeit).TotalSeconds <= 1) // Schleife umgebaut das sie 10 sekunden lang läuft (DateTime.Now)
            {
                EuroJackpot(Liste1, Liste2); // Lottzahlen Generieren !
                Treffer[CompareLotto(Liste1, Liste2, MyNumbers, MySpecial)]++;
                Versuche++;
            }
            PrintLotto(Liste1, Liste2, MyNumbers, MySpecial, Treffer, Versuche); // Lottozahlen Ausgeben !

            
            //TODO: Ausgabe des arrays und der zählvariable
        }

        //TODO: Methode bauen welche einen Lottoschein mit dem Lottoergebnis vergleicht
        //      rückgabe soll die anzahl der korrekten zahlen sein (List.contains)
        static int CompareLotto(List<byte> Numbers, List<byte> Special, List<byte> MyNumbers, List<byte> MySpecial)
        {

            int Richtige = 0; // ergebnisvariable erstellen
            foreach (var Gezogen in Numbers) // schleife welche durch die gesamte Special-Liste geht
            {
                foreach (var Eingetragen in MyNumbers) // schleife welche durch die gesamte PrePickedSpecial-Liste geht
                {
                    if (Gezogen == Eingetragen) // wenn element der äusseren schleife und der inneren identisch sind
                    {
                        Richtige++; // wenn element der äusseren schleife und der inneren identisch sind
                        break;
                    }
                }
            }
            foreach (var Gezogen in Special) // schleife welche durch die gesamte Special-Liste geht
            {
                foreach (var Eingetragen in MySpecial) // schleife welche durch die gesamte PrePickedSpecial-Liste geht
                {
                    if (Gezogen == Eingetragen) // wenn element der äusseren schleife und der inneren identisch sind
                    {
                        Richtige++; // wenn element der äusseren schleife und der inneren identisch sind
                        break;
                    }
                }
            }
            return Richtige;// rückgabe ergebnisvariable
        }
        static void PrintLotto(List<byte> Numbers, List<byte> Special, List<byte> MyNumbers, List<byte> MySpecial, Array Treffer, int Versuche)
        {
            int hit = 0;
            foreach (var item in Numbers) 
            {
                Console.Write("{0,3}", item);
            }
            foreach (var item in Special)
            {
                Console.Write("{0,2}", item);
            }
            Console.Write(": EuroJackpot (Letzte Ausgegebene Zahlen)");
            Console.WriteLine();
            foreach (var item in MyNumbers)
            {
                Console.Write("{0,3}", item);
            }
            foreach (var item in MySpecial)
            {
                Console.Write("{0,2}", item);
            }
            Console.Write(": Meine LottoZahlen");
            Console.WriteLine();
            foreach (var item in Treffer)
            {
                Console.Write("{0} ", hit , hit++);
                Console.WriteLine("Richtige: {0} ", item);
            }
            Console.WriteLine();
            Console.WriteLine("Versuche: {0}", Versuche.ToString("0,00"));
            Console.WriteLine("Enspricht: " + (2.5*Versuche).ToString("0,00") + " Euro");
        }
        static void EuroJackpot(List<byte> Numbers, List<byte> Special)
        {

            //Eurojackpot
            // 5x 1 - 50 
            // 2x 1 - 10
            Random rndGen = new Random();

            Numbers.Clear();
            Special.Clear();

            while (Numbers.Count < 5)
            {
                byte newNumber = (byte)rndGen.Next(1, 51);
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
                byte newNumber = (byte)rndGen.Next(1, 11);
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
