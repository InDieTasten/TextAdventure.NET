using System;
using System.Collections.Generic;
using System.Linq;

namespace TextAdventure
{
    public class GameBuilder
    {
        private List<Scene> Scenes { get; set; } = new List<Scene>();
        private Action<string> OutputMethod { get; set; } = Console.WriteLine;

        public void AddScene<TScene>() where TScene : Scene,new()
        {
            Scenes.Add(new TScene());
        }

        public Game Build()
        {
            ValidateSetup(true);

            var game = new Game()
            {
                Scenes = Scenes,
                GameFlow = _ => _.Scenes.ForEach(scene =>
                {
                    scene.Enter();
                }),
                OutputMethod = OutputMethod
            };
            game.Scenes.ForEach(scene => scene.Game = game);

            return game;
        }

        public void DefineOutputMethod(Action<string> outputMethod)
        {
            if (outputMethod is null)
            {
                throw new ArgumentNullException(nameof(outputMethod));
            }

            OutputMethod = outputMethod;
        }

        private void ValidateSetup(bool displayWarnings)
        {
            if (Scenes.Any(scene => !scene.IsLinear))
            {
                throw new NotSupportedException("Currently only linear navigation is supported");
            }
        }
    }
}
