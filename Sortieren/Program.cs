using System;

namespace Sortieren
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayToSort = new int[] { 3,5,2,1,4 };
            Console.WriteLine("Vor dem Sortieren: ");
            foreach (int Zahl in ArrayToSort)
            {
                Console.Write(Zahl + " ");
            }
            Sort(ArrayToSort);
        }

        static void Sort(int[] ArrayToSort)
        {
            // zählen von 0 solange kleines als Arraylänge
            for (int i = 0; i < ArrayToSort.Length; i++)
            {
                for (int j = i; j < ArrayToSort.Length; j++)
                {
                    if (ArrayToSort[i] > ArrayToSort[j])
                    {
                        int backup = ArrayToSort[i];
                        ArrayToSort[i] = ArrayToSort[j];
                        ArrayToSort[j] = backup;
                    }
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Nach dem Sortieren: ");
            foreach (int Zahl in ArrayToSort)
            {
                Console.Write(Zahl + " ");
            }
            // ende Zähler
        }
    }
}
