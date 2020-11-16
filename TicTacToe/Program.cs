using System;
using System.Security.Cryptography;

namespace TicTacToe
{
    class Program
    {
        static void Draw()
        {
            for (int reihe = 0; reihe < 3; reihe++) // reihe zählen von 0 solange kleiner als 3
            {
                for (int spalte = 0; spalte < 3; spalte++) //    spalte zählen von 0 solange kleiner als 3
                {
                    if () // wenn im spielfeld an koordinate reihe,spalte leer steht
                    {

                    }
                    return ; //          ausgabe leerzeichen
                    if () // wenn im spielfeld an koordinate reihe,spalte X steht
                    {

                    }
                    return; //          ausgabe eines X
                    if () // wenn im spielfeld an koordinate reihe,spalte O steht
                    {

                    }
                    return; //          ausgabe eines O
                    if () // wenn im spielfeld an koordinate reihe,spalte hint steht
                    {

                    }
                    return; //          ausgabe eines leerzeichens mit anderer hintergrundfarbe
                }//    ende zählen spalte
            }// ende zählen reihe
        }
        static void Main()
        {
            Spielfeld
            Console.WriteLine("Willkommen bei TicTacToe!"); // ausgabe begrüssung
            Console.WriteLine("Spieler X - Bitte Namen eingeben: "); // ausgabe Spieler X bitte name eingeben
            string Player1 = Console.ReadLine(); // eingabe von tastatur lesen und abspeichern
            Console.Clear();
            Console.WriteLine("Spieler Y - Bitte Namen eingeben: ");// ausgabe Spieler Y bitte name eingeben
            string Player2 = Console.ReadLine(); // eingabe von tastatur lesen und abspeichern  
            Console.Clear();
            do // wiederholen
            {
                //   spiel auf anfangszustand setzen
                do //   wiederholen
                {
                    //      spielfeld anzeigen
                    do //      wiederholen
                    {
                        //          ausgabe Bitte feld auswählen
                        //          eingabe des feldes lesen und abspeichern
                        //          zug durchführen und ergebnis abspeichern
                    } while (true); //      solange Spielerzug ungültig
                } while (true); //   solange Spielerzug gültig
                //   wenn spielerzug unentschieden
                //      ausgabe unentschieden
                //   andernfalls
                //      ausgabe aktueller spieler hat gewonnen
                //   ausgabe möchten sie noch ein spiel?
            } while (true);// solange y von der tastatur gelesen wurde

        }
    }
}
