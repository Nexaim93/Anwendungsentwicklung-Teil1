using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace GameOfLife
{
    internal class GameField
    {
        bool[,] FieldTrue; // Das Erste Feld als Bool mit Y , X Bool
        bool[,] FieldFalse; // Das Zweite Feld als Bool mit Y , X Bool
        bool FieldToRead; // 


        public bool[,] GetAktiveField
        {
            get { return (FieldToRead ? FieldTrue : FieldFalse); }
        }

        void SetValue(int X, int Y, bool value)
        {
            if (FieldToRead)
            {
                FieldFalse[Y, X] = value;
            }
            if (FieldToRead)
            {
                FieldTrue[Y, X] = value;
            }
        }
        public GameField()
        {
            FieldFalse = new bool[20, 30];
            FieldTrue = new bool[20, 30];
            FieldToRead = false;

            Reset();
        }

        public void Reset()
        {
            Random rndGen = new();
            for (int Y = 0; Y < FieldFalse.GetLength(0); Y++)
            {
                for (int X = 0; X < FieldFalse.GetLength(1); X++)
                {
                    FieldFalse[Y, X] = rndGen.NextDouble() > 0.8d;
                }
            }
        }

        public void Update()
        {
            for (int Y = 0; Y < FieldFalse.GetLength(0); Y++)
            {
                for (int X = 0; X < FieldFalse.GetLength(1); X++)
                {
                    if (GetAktiveField[Y, X])
                    {
                        // lebender bereich
                        if (aliveNeighbors(X, Y) is < 2 or > 3) //C# 9 vergleich mit zwei bedingungen
                        {
                            // wenn weniger als 2 lebende angrenzen auf tot setzen
                            // wenn mehr als 3 lebende angrenzen auf tot setzen
                            SetValue(X, Y, false);
                        }
                        else
                            SetValue(X, Y, true);                  

                    }
                    else
                    {
                        // toter bereich
                        if (aliveNeighbors(X, Y) == 3)
                        {
                            // wenn exakt 3 lebende angrenzen auf lebend setzen
                            SetValue(X, Y, true);
                        }
                        else
                            SetValue(X, Y, false);

                    }
                }
            }
            FieldToRead = !FieldToRead;
        }

        private int aliveNeighbors(int x, int y)
        {
            int living = 0;
            for (int row = y - 1; row < y + 2; row++)
            {
                for (int col = x - 1; col < x + 2; col++)
                {
                    if (row > -1 && col > -1 && // ignorieren von zu kleinen zählern
                        row < GetAktiveField.GetLength(0) && col < GetAktiveField.GetLength(1) && // ignorieren von zu grossen zählern
                        !(row == y && col == x) && GetAktiveField[row, col])
                    {
                        living++;
                    }
                }
            }
            return living;
        }

        public bool LoadGame(string FileName)
        {
            if (! File.Exists(FileName))
            {
                return false;
            }

            XmlSerializer serializer = new(typeof(SaveGame));
            SaveGame sg;

            using (Stream file = new FileStream(FileName, FileMode.Open, FileAccess.Read))
            {
                sg = (SaveGame)serializer.Deserialize(file);
            }
            FieldFalse = sg.GetAktiveField;

            return true;
        }

    }
}
