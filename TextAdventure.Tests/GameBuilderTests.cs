using System;
using TextAdventure.Tests.Scenes;
using Xunit;
using Xunit.Abstractions;

namespace TextAdventure.Tests
{
    public class GameBuilderTests
    {
        private readonly ITestOutputHelper _output;

        public GameBuilderTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void CanConstruct()
        {
            new GameBuilder();
        }

        [Fact]
        public void CanSatisfyUsage()
        {
            var gameBuilder = new GameBuilder();

            gameBuilder.DefineOutputMethod(_output.WriteLine);
            gameBuilder.AddScene<LinearSceneA>();
            gameBuilder.AddScene<LinearSceneB>();

            var game = gameBuilder.Build();
            game.Launch();
        }
    }
}
