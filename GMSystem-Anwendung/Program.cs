using System;
using System.IO;

namespace GMSystem_Anwendung
{
    class Program
    {
        static void Main(string[] args)
        {
            HauptLogo("Texte/Willkommen.txt");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            HauptLogo("Texte/bei.txt");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            HauptLogo("Texte/GMSystem.txt");
            string NamenEingeben = "Gib deinen Namen ein:";
            Console.SetCursorPosition(Console.WindowWidth/2 - NamenEingeben.Length/2, 8);
            Console.Write(NamenEingeben + " ");
            String UserName = Console.ReadLine();
            

        }

        static void HauptLogo(string HauptLogo)
        {
            using (var reader = new StreamReader(HauptLogo))
            {
                int Y = 1;
                while ((HauptLogo = reader.ReadLine()) != null)
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2 - HauptLogo.Length/2, 1 + Y);
                    Console.WriteLine(HauptLogo);
                    System.Threading.Thread.Sleep(25);
                    Y++;
                }
                Console.SetCursorPosition(1, 1);
            }
        }
    }
}
