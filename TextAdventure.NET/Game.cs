using System;
using System.Collections.Generic;
using System.IO;

namespace TextAdventure
{
    public class Game
    {
        internal LaunchSettings LaunchSettings { get; set; }
        internal List<Scene> Scenes { get; set; }
        internal Action<Game> GameFlow { get; set; }

        public void Launch()
        {
            Launch(LaunchSettings.Default);
        }
        public void Launch(LaunchSettings launchSettings)
        {
            LaunchSettings = launchSettings;
            GameFlow.Invoke(this);
        }

        public TextWriter Output => LaunchSettings.Output;
        public TextReader Input => LaunchSettings.Input;
    }
}
