using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{
    class GameField
    {
        private bool[,] FieldTrue;
        private bool[,] FieldFalse;
        private bool FieldToRead;

        public GameField()
        {
            FieldFalse = new bool[20, 30];
            FieldTrue = new bool[20, 30];
            FieldToRead = false;

            Random rndGen = new Random();

            for (int Y = 0; Y < FieldFalse.GetLength(0); Y++)
            {
                for (int X = 0; X < FieldFalse.GetLength(1); X++)
                {
                    FieldFalse[Y, X] = rndGen.NextDouble() > 0.8d;
                }
            }
        }

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

        public void Reset(int FieldX,int FieldY)
        {
            FieldTrue = new bool[FieldX,FieldY];
            FieldFalse = new bool[FieldX,FieldY];
            // ToDo: Einige Felder zum Leben erwecken!
        }

        public void Update()
        {
            for (int Y = 0; Y < FieldFalse.GetLength(0); Y++)
            {
                for (int X = 0; X < FieldFalse.GetLength(1); X++)
                {



                    if (FieldFalse[Y, X])
                    {
                        // lebender bereich
                        // wenn weniger als 2 lebende angrenzen auf tot setzen
                        // wenn mehr als 3 lebende angrenzen auf tot setzen

                    }
                    else
                    {
                        // toter bereich
                        // wenn exakt 3 lebende angrenzen auf lebend setzen

                    }
                }
            }
        }

        public bool LoadGame(string FileName)
        {
            return true;
        }

        public bool SaveGame(string FileName)
        {
            return true;
        }

    }
}
