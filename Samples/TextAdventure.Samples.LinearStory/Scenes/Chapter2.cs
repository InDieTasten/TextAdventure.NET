namespace TextAdventure.Samples.LinearStory.Scenes
{
    internal class Chapter2 : Scene
    {
        public override void Enter()
        {
            Display("You've now entered Chapter 2 of the sequential story. What might be the next chapter?");
            LogFault("Something went wrong in Chapter 2");
        }
    }
}