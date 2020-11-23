using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{
    internal class Intro : Scene
    {
        public Intro()
        {
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("Intro");
        }
        public override void Update()
        {
            if (Console.KeyAvailable)
            {
                Program.Scenes.Pop();
                Program.Scenes.Push(new MainMenu());
            }
        }
    }
}
