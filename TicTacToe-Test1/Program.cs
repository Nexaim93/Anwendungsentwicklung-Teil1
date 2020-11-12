using System;

namespace TicTacToe_Test1
{
    class Program
    {
        /// <summary>
        /// Hauptmethode
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string[] spielfeld = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            //Namen von Spieler
            Console.WriteLine("****TicTacToe****");
            Console.Write("Spieler 1 bitte Name eingeben: ");
            string Spieler1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("****TicTacToe****");
            Console.Write("Spieler 2 bitte Name eingeben: ");
            string Spieler2 = Console.ReadLine();

            //Hauptschleife
            int zähler = 0;
            do
            {
                //Bildschirminhalt wird gelöscht und das Spilefeld wird ausgegeben
                Console.Clear();
                Console.WriteLine("****TicTacToe****");
                Console.WriteLine();
                Console.WriteLine("   " + spielfeld[0] + " | " + spielfeld[1] + " |  " + spielfeld[2] + "    ");
                Console.WriteLine("     |   |           ");
                Console.WriteLine(" -------------    ");
                Console.WriteLine("   " + spielfeld[3] + " | " + spielfeld[4] + " |  " + spielfeld[5] + "    ");
                Console.WriteLine(" -------------    ");
                Console.WriteLine("     |   |            ");
                Console.WriteLine("   " + spielfeld[6] + " | " + spielfeld[7] + " |  " + spielfeld[8] + "    ");
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------------");

                //Hier wird der erste Spielzug eingegeben
                int zahl;
                Console.Write("Geben sie eine Zahl ein " + Spieler1 + ":");
                string eingabe = Console.ReadLine();
                zahl = Convert.ToInt32(eingabe);
                zahl = zahl - 1;

                //Überprüfung von gültiger Zahl
                while (zahl > 8 || zahl < 0)
                {
                    Console.WriteLine("Geben sie eine gültige Zahl ein:");
                    eingabe = Console.ReadLine();
                    zahl = Convert.ToInt32(eingabe);
                    zahl = zahl - 1;
                }
                //Überprüfung auf leeres Feld
                if (spielfeld[zahl] == "X" || spielfeld[zahl] == "O")
                {
                    Console.WriteLine("Feld besetzt");
                }
                spielfeld[zahl] = "X";


                if (MuehlePruefen(spielfeld) == true)
                {
                    Console.WriteLine("Nochmal????");
                    Console.WriteLine();
                    Console.WriteLine("Bitte Eingabetaste für nochmal Drücken");
                    Console.WriteLine();
                    Console.WriteLine("Sonst bitte StrG + C zum beenden");
                    Console.ReadLine();
                    Console.Clear();
                    Main(args);
                }

                //Hier beginnt das Spielfeld für den 2ten spieler
                Console.Clear();
                Console.WriteLine("****TicTacToe****");
                Console.WriteLine();
                Console.WriteLine("   " + spielfeld[0] + " | " + spielfeld[1] + " |  " + spielfeld[2] + "    ");
                Console.WriteLine("     |   |           ");
                Console.WriteLine(" -------------    ");
                Console.WriteLine("   " + spielfeld[3] + " | " + spielfeld[4] + " |  " + spielfeld[5] + "    ");
                Console.WriteLine(" -------------    ");
                Console.WriteLine("     |   |            ");
                Console.WriteLine("   " + spielfeld[6] + " | " + spielfeld[7] + " |  " + spielfeld[8] + "    ");
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------------");
                zähler++;

                //Hier wird der erste Spielzug von Spiler 2 eingegeben
                int zahl2;
                Console.Write("Geben sie eine Zahl ein " + Spieler2 + ":");
                string eingabe2 = Console.ReadLine();
                zahl2 = Convert.ToInt32(eingabe2);
                zahl2 = zahl2 - 1;

                //Überprüfung von gültiger Zahl
                while (zahl2 > 8 || zahl2 < 0)
                {
                    Console.WriteLine("Geben sie eine gültige Zahl ein:");
                    eingabe2 = Console.ReadLine();
                    zahl2 = Convert.ToInt32(eingabe2);
                    zahl2 = zahl2 - 1;
                }
                //Überprüfung auf leeres Feld
                if (spielfeld[zahl2] == "O" || spielfeld[zahl2] == "O")
                {
                    Console.WriteLine("Feld besetzt");
                }
                spielfeld[zahl2] = "O";


                if (MuehlePruefen(spielfeld) == true)
                {
                    Console.WriteLine("Nochmal????");
                    Console.WriteLine();
                    Console.WriteLine("Bitte Eingabetaste für nochmal Drücken");
                    Console.WriteLine();
                    Console.WriteLine("Sonst bitte StrG + C zum beenden");
                    Console.ReadLine();
                    Console.Clear();
                    Main(args);
                }
            } while (zähler < 4);//Bei einem Unentschieden bricht die while-Schleife automatisch ab und starteet das Spiel neu

            Console.WriteLine("Unentschieden!!!!");
            Console.WriteLine();
            Console.WriteLine("Bitte Eingabetaste für nochmal Drücken");
            Console.WriteLine();
            Console.WriteLine("Sonst bitte StrG + C zum beenden");
            Console.ReadLine();
            Console.Clear();
            Main(args);

        }

        //Mühlenprüfung
        private static bool MuehlePruefen(string[] spielfeld)
        {
            //Überprüft ob Spieler mit Spielstein X gewonnen hat
            if (((spielfeld[0] == "X") && (spielfeld[1] == "X") && (spielfeld[2] == "X")) || ((spielfeld[3] == "X") && (spielfeld[4] == "X") && (spielfeld[5] == "X")) || ((spielfeld[6] == "X") && (spielfeld[7] == "X") && (spielfeld[8] == "X")) || ((spielfeld[0] == "X") && (spielfeld[4] == "X") && (spielfeld[8] == "X")) || ((spielfeld[2] == "X") && (spielfeld[4] == "X") && (spielfeld[6] == "X")) || ((spielfeld[0] == "X") && (spielfeld[3] == "X") && (spielfeld[6] == "X")) || ((spielfeld[1] == "X") && (spielfeld[4] == "X") && (spielfeld[7] == "X")) || ((spielfeld[2] == "X") && (spielfeld[5] == "X") && (spielfeld[8] == "X")))
            {
                Console.WriteLine("Spieler mit Spielstein X hat gewonnen!!!!!!");
                return true;
            }
            //Überprüft ob Spieler mit Spielstein O gewonnen hat
            else if (((spielfeld[0] == "O") && (spielfeld[1] == "O") && (spielfeld[2] == "O")) || ((spielfeld[3] == "O") && (spielfeld[4] == "O") && (spielfeld[5] == "O")) || ((spielfeld[6] == "O") && (spielfeld[7] == "O") && (spielfeld[8] == "O")) || ((spielfeld[0] == "O") && (spielfeld[4] == "O") && (spielfeld[8] == "O")) || ((spielfeld[2] == "O") && (spielfeld[4] == "O") && (spielfeld[6] == "O")) || ((spielfeld[0] == "O") && (spielfeld[3] == "O") && (spielfeld[6] == "O")) || ((spielfeld[1] == "O") && (spielfeld[4] == "O") && (spielfeld[7] == "O")) || ((spielfeld[2] == "O") && (spielfeld[5] == "O") && (spielfeld[8] == "O")))
            {
                Console.WriteLine("Spieler mit Spielstein O hat gewonnen!!!!!!");
                return true;
            }

            return false;
        }

    }

}