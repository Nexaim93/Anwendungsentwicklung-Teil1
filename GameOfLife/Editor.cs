using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{
    internal class Editor : Scene
    {
        public override void Update()
        {
            Console.Clear();
            Console.WriteLine("Test");

            if (Console.KeyAvailable)
            {
                Program.Scenes.Pop();
            }
        }
    }
}
