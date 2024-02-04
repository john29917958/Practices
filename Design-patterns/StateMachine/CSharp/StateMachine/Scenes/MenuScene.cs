using System;

namespace StateMachine.Scenes
{
    class MenuScene : Scene
    {
        public MenuScene(SceneController controller) : base(controller)
        {

        }

        public override void Start()
        {
            Console.WriteLine("Menu scene started");
        }

        public override void Update()
        {
            Console.WriteLine("Menu scene updated");
        }

        public override void End()
        {
            Console.WriteLine("Menu scene ended");
        }
    }
}
