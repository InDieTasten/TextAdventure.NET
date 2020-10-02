using System;
using System.Collections.Generic;
using System.Linq;

namespace TextAdventure
{
    public class GameBuilder
    {
        private List<Scene> Scenes { get; set; } = new List<Scene>();



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
                })
            };
            game.Scenes.ForEach(scene => scene.Game = game);

            return game;
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
