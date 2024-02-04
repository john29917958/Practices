using System;

namespace StateMachine.Scenes
{
    class BattleScene : Scene
    {
        public BattleScene(SceneController controller) : base(controller)
        {

        }

        public override void Start()
        {
            Console.WriteLine("Battle scene started");
        }

        public override void Update()
        {
            Console.WriteLine("Battle scene updated");
        }

        public override void End()
        {
            Console.WriteLine("Battle scene ended");
        }
    }
}
