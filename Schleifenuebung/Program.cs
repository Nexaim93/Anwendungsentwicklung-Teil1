using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.IO.Ports;

namespace Schleifenuebung
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wortschleife();

            /*string Vorgeschlagen = null;
            string NeuGenerieren = null;
            string Eigen = null;
            string Close = null;*/
            String TextWillkommen = "Herzlich Willkommen bei Georgi's EuroJackpor-Automat";
            String TextVorgehen = "Wähle bitte:";
            ConsoleColor Safe;
            Random rndColor = new Random();
            List<ConsoleColor> VerboteneFarben = new List<ConsoleColor>();    

            Console.CursorVisible = false;
            String[] Logo = new string[] {"######## ##     ## ########   #######        ##    ###     ######  ##    ## ########   #######  ######## ",
                                          "##       ##     ## ##     ## ##     ##       ##   ## ##   ##    ## ##   ##  ##     ## ##     ##    ##    ",
                                          "##       ##     ## ##     ## ##     ##       ##  ##   ##  ##       ##  ##   ##     ## ##     ##    ##    ",
                                          "######   ##     ## ########  ##     ##       ## ##     ## ##       #####    ########  ##     ##    ##    ",
                                          "##       ##     ## ##   ##   ##     ## ##    ## ######### ##       ##  ##   ##        ##     ##    ##    ",
                                          "##       ##     ## ##    ##  ##     ## ##    ## ##     ## ##    ## ##   ##  ##        ##     ##    ##    ",
                                          "########  #######  ##     ##  #######   ######  ##     ##  ######  ##    ## ##         #######     ##    "};

            for (int i = 0; i < Logo.Length; i++)
            {
                do
                {
                    Safe = (ConsoleColor)rndColor.Next(1, 16);
                }
                while (VerboteneFarben.Contains(Safe));
                VerboteneFarben.Add(Safe);
                Console.ForegroundColor = Safe;

                Console.SetCursorPosition(Console.WindowWidth/2 - Logo[0].Length/2, 1 +i);
                Console.Write(Logo[i]);
                System.Threading.Thread.Sleep(100);
            }
            Console.ResetColor();
            System.Threading.Thread.Sleep(500);


            Typewrite(TextWillkommen,1);
            Console.WriteLine("\n");
            System.Threading.Thread.Sleep(500);
            Typewrite(TextVorgehen,2);
            System.Threading.Thread.Sleep(500);

            int SelectedButton = 0;
            bool Menu = true;

            String[] ButtonTexte = new String[] {"Generierten Lottschein nehmen","Neu Generieren","Eigenen Lottoschein Ausfüllen","Schliessen"};
            while (Menu)
            {
                for (int i = 0; i < ButtonTexte.Length; i++)
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2 - ButtonTexte[i].Length/2, 12 +i);
                    if (i == SelectedButton)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(ButtonTexte[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(ButtonTexte[i]);
                        Console.ResetColor();
                    }
                }
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        if (SelectedButton > 0)
                        {
                            --SelectedButton;
                        }
                        else
                        {
                            SelectedButton = ButtonTexte.Length -1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (SelectedButton < ButtonTexte.Length -1)
                        {
                            ++SelectedButton;
                        }
                        else
                        {
                            SelectedButton = 0;
                        }
                        break;
                    case ConsoleKey.Enter:
                        Console.SetCursorPosition(0, 15);
                        switch (SelectedButton)
                        {
                            case 0:
                                Console.WriteLine("test 1");
                                break;
                            case 1:
                                Console.WriteLine("test 2");
                                break;
                            case 2:
                                Console.WriteLine("test 3");
                                break;
                            case 3:
                                Menu = false;                              
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.Clear();
            Typewrite("Byyye...........",1);
            System.Threading.Thread.Sleep(500);
            Console.Clear();

            for (int i = 0; i < Logo.Length; i++)
            {
                do
                {
                    Safe = (ConsoleColor)rndColor.Next(1, 16);
                }
                while (VerboteneFarben.Contains(Safe));
                VerboteneFarben.Add(Safe);
                Console.ForegroundColor = Safe;

                Console.SetCursorPosition(Console.WindowWidth/2 - Logo[0].Length/2, 1 + i);
                Console.WriteLine(Logo[i]);
                System.Threading.Thread.Sleep(100);
            }
            Console.ResetColor();


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

            /*
            int Versuche = 0;
            while ((DateTime.Now - Startzeit).TotalSeconds <= 1) // Schleife umgebaut das sie 10 sekunden lang läuft (DateTime.Now)
            {
                EuroJackpot(Liste1, Liste2); // Lottzahlen Generieren !
                Treffer[CompareLotto(Liste1, Liste2, MyNumbers, MySpecial)]++;
                Versuche++;
            }
            PrintLotto(Liste1, Liste2, MyNumbers, MySpecial, Treffer, Versuche); // Lottozahlen Ausgeben !
            Console.ReadLine();
            */

            //TODO: Ausgabe des arrays und der zählvariable
        }

        //TODO: Methode bauen welche einen Lottoschein mit dem Lottoergebnis vergleicht
        //      rückgabe soll die anzahl der korrekten zahlen sein (List.contains)
        static void Typewrite(string message, int Y)
        {
            Console.SetCursorPosition(Console.WindowWidth/2 - message.Length/2, 8 +Y);
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]); // Buchtabe für Buchtabe schreiben !
                System.Threading.Thread.Sleep(10); // Geschwindigkeit des Schreibens
            }
        }
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
                Console.Write("{0} ", hit, hit++);
                Console.WriteLine("Richtige: {0} ", item);
            }
            Console.WriteLine();
            Console.WriteLine("Versuche: {0}", Versuche.ToString("0,00"));
            Console.WriteLine("Enspricht: " + (2.5 * Versuche).ToString("0,00") + " Euro");
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
