using System;

namespace TextAdventure
{
    public class Scene
    {
        internal Game Game { get; set; }

        public Scene()
        {
            Text = $"The Text property of scene '{GetType().Name}' was not set";
        }

        public string Text { get; set; }
        public virtual bool IsLinear => true;

        public virtual void Enter()
        {
            Display(Text);
        }

        protected void Display(string text)
        {
            Game.OutputMethod(text);
        }
    }
}