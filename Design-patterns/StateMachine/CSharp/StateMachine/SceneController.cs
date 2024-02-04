using StateMachine.Scenes;

namespace StateMachine
{
    class SceneController
    {
        private Scene _scene;

        public SceneController()
        {
            
        }

        public void SetScene(Scene scene)
        {
            _scene?.End();
            _scene = scene;
            _scene.Start();
        }

        public void Update()
        {
            _scene?.Update();
        }
    }
}
