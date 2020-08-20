using System;
using System.Collections.Generic;

namespace TextAdventure
{
    public class Game
    {
        public Action<string> OutputMethod { get; internal set; }
        internal List<Scene> Scenes { get; set; }
        internal Action<Game> GameFlow { get; set; }

        public void Launch()
        {
            GameFlow.Invoke(this);
        }
    }
}
