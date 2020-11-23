using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{
    internal class MainMenu : Scene
    {
        public MainMenu()
        {
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("Willkommen im Hauptmenü");
        }
        public override void Update()
        {
            if (Console.KeyAvailable)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Escape:
                        Program.Scenes.Pop();
                        break;
                    case ConsoleKey.Enter:
                        Program.Scenes.Push(new Game());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
