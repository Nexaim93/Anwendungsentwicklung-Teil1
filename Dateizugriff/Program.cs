using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Dateizugriff
{
    [Serializable] class Auto // Der Inhalt der Klasse soll Serialisiert werden in Binary
    {
        public int Tempo;
        public string Name;
        [NonSerialized] public bool geheim;
    }

    public class Hund
    {
        public string Name;
        public byte Alter;
        public List<Bein> Beine;
    }

    public class Bein
    {
        public byte AnzahlBeine;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //SaveAndLoadXML();
            //SaveAndLoadBinary();
            LoadText();
        }

        static void LoadText()
        {
            // Liest die gesamte Datei ein und gibt sie auf die Konsole aus.
            using (var reader = new StreamReader("BeispielText.txt"))
            {
                string DateiInhalt = reader.ReadToEnd();
                Console.WriteLine(DateiInhalt);
            }

            Console.ReadLine();
            Console.Clear();

            using (var reader = new StreamReader("BeispielText.txt"))
            {
                string Zeile;
                while ((Zeile = reader.ReadLine()) != null)
                {
                    Console.WriteLine(Zeile);
                    Console.ReadLine();
                }
            }

        }

        static void SaveAndLoadXML()
        {
            Hund meinHund = new Hund();
            meinHund.Alter = 5;
            meinHund.Name = "Wuffi";
            meinHund.Beine = new List<Bein>();
            meinHund.Beine.Add(new Bein());
            meinHund.Beine.Add(new Bein());
            meinHund.Beine.Add(new Bein());
            meinHund.Beine.Add(new Bein());

            XmlSerializer formXML = new XmlSerializer(typeof(Hund)); // Muss angegeben werden welche Class Serialisiert werden soll

            using (Stream datei = new FileStream("GespeicherterHund.xml", FileMode.Create, FileAccess.Write))
            {
                formXML.Serialize(datei, meinHund);
            }

            Console.WriteLine("Hund gespeichert");

            Hund geladenerHund;

            using (Stream datei = new FileStream("GespeicherterHund.xml", FileMode.Open, FileAccess.Read))
            {
                geladenerHund = (Hund)formXML.Deserialize(datei);
            }
            Console.WriteLine("Hund wurde wieder geladen!");

        }

        static void SaveAndLoadBinary()
        {
            Auto myCar = new Auto(); // Auto Erstellen -> Es muss die dazu gehörige Class exisiteren -> Class Auto
            myCar.Name = "Ferrari Maranello"; // Befüllen!
            myCar.Tempo = 320; // Befüllen!
            myCar.geheim = true; // Befüllen!

            BinaryFormatter formBin = new BinaryFormatter(); // Formatter erstellen

            using (Stream myFileStream = new FileStream("GespeichertesAuto.bin", FileMode.Create, FileAccess.Write)) // Ich hätte gern die datei mit "Name", FileMode z.B erstellen , FileAcces z.B Schreiben, Lesen oder Lesen & Schreiben
            {
                formBin.Serialize(myFileStream, myCar); // Formatter sagen er soll ein Object Serilisieren ( Benutzen von myFileStream um eine Datei zu erstellen, mit den Inhalt von myCar)
            }

            Console.WriteLine("Das Auto wurde gespeichert");

            Auto meinGeladenesAuto;
            using (Stream myFileStream = new FileStream("GespeichertesAuto.bin", FileMode.Open, FileAccess.Read))
            {
                meinGeladenesAuto = (Auto)formBin.Deserialize(myFileStream); // Object wieder zurückformatieren mit Deserialize was in myFileStream vorher definiert wurde
            }

            if (meinGeladenesAuto.Name == myCar.Name && meinGeladenesAuto.Tempo == myCar.Tempo)
            {
                Console.WriteLine("Das Auto wurde erfolgreich geladen {0}", meinGeladenesAuto.geheim);
            }
        }
    }
}

