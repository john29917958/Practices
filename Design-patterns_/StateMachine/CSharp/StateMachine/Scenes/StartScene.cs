using System;

namespace StateMachine.Scenes
{
    class StartScene : Scene
    {
        public StartScene(SceneController controller) : base(controller)
        {

        }

        public override void Start()
        {
            Console.WriteLine("Start scene started");
        }

        public override void Update()
        {
            Console.WriteLine("Start scene updated");
        }

        public override void End()
        {
            Console.WriteLine("Start scene ended");
        }
    }
}
