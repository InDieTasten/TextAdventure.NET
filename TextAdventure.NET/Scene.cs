namespace TextAdventure
{
    public abstract class Scene
    {
        internal Game Game { get; set; }

        public Scene()
        {
        }

        public virtual bool IsLinear => true;

        public abstract void Enter();

        protected void Display(string text)
        {
            Game.Output.WriteLine(text);
        }

        protected void LogFault(string faultMessage)
        {
            Game.Error.WriteLine(faultMessage);
        }
    }
}