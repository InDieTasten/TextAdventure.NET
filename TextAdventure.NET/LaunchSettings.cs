using System;
using System.IO;

namespace TextAdventure
{
    public class LaunchSettings
    {
        public TextWriter Output { get; set; }
        public TextReader Input { get; set; }

        public static LaunchSettings Default = new LaunchSettings
        {
            Output = Console.Out,
            Input = Console.In
        };
    }
}