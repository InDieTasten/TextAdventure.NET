using TextAdventure.Samples.LinearStory.Scenes;

namespace TextAdventure.Samples.LinearStory
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameBuilder = new GameBuilder();

            gameBuilder.AddScene<Introduction>();
            gameBuilder.AddScene<Chapter1>();
            gameBuilder.AddScene<Chapter2>();
            gameBuilder.AddScene<Chapter3>();
            gameBuilder.AddScene<End>();

            var game = gameBuilder.Build();

            game.Launch();
        }
    }
}
