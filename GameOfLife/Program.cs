using System;
using System.Collections.Generic;
using System.Drawing;

namespace GameOfLife
{
    class Program
    {
        public static Stack<Scene> Scenes = new Stack<Scene>();
        static void Main()
        {
            Scenes.Push(new Intro());

            do
            {
                Scenes.Peek().Update();
            } while (Scenes.Count > 0);
        }
    }
}
