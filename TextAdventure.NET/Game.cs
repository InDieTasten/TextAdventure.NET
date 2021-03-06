﻿using System;
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
            Launch(LaunchSettings.DevelopmentMode);
        }
        public void Launch(LaunchSettings launchSettings)
        {
            LaunchSettings = launchSettings;
            GameFlow.Invoke(this);
            Output.Flush();
            Error.Flush();
        }

        public TextWriter Output => LaunchSettings.Output;
        public TextReader Input => LaunchSettings.Input;
        public TextWriter Error => LaunchSettings.Error;
    }
}
