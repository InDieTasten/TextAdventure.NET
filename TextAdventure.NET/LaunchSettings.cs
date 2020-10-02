using System;
using System.IO;

namespace TextAdventure
{
    public class LaunchSettings
    {
        public TextWriter Output { get; set; }
        public TextReader Input { get; set; }
        public TextWriter Error { get; set; }

        /// <summary>
        /// Game errors are logged directly into the console
        /// </summary>
        public static LaunchSettings DevelopmentMode = new LaunchSettings
        {
            Output = Console.Out,
            Input = Console.In,
            Error = Console.Error
        };

        /// <summary>
        /// Game errors are logged into an ErrorLog.txt file
        /// </summary>
        public static LaunchSettings ProductionMode = new LaunchSettings
        {
            Output = Console.Out,
            Input = Console.In,
            Error = new StreamWriter("ErrorLog.txt", true)
        };
    }
}