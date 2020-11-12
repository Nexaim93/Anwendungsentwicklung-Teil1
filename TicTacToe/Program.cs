using System;

namespace TicTacToe
{
    class Program
    {
        static void Draw()
        {
            // reihe zählen von 0 solange kleiner als 3
            //    spalte zählen von 0 solange kleiner als 3
            //      wenn im spielfeld an koordinate reihe,spalte leer steht
            //          ausgabe leerzeichen
            //      wenn im spielfeld an koordinate reihe,spalte X steht
            //          ausgabe eines X
            //      wenn im spielfeld an koordinate reihe,spalte O steht
            //          ausgabe eines O
            //      wenn im spielfeld an koordinate reihe,spalte hint steht
            //          ausgabe eines leerzeichens mit anderer hintergrundfarbe
            //    ende zählen spalte
            // ende zählen reihe
        }
        static void Main()
        {
            Spielfeld
            Console.WriteLine("Willkommen bei TicTacToe!"); // ausgabe begrüssung
            Console.WriteLine("Spieler X - Bitte Namen eingeben: "); // ausgabe Spieler X bitte name eingeben
            string Player1 = Console.ReadLine(); // eingabe von tastatur lesen und abspeichern
            Console.WriteLine("Spieler Y - Bitte Namen eingeben: ");// ausgabe Spieler Y bitte name eingeben
            string Player2 = Console.ReadLine(); // eingabe von tastatur lesen und abspeichern  
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
