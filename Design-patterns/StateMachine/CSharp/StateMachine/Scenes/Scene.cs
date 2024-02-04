namespace StateMachine.Scenes
{
    abstract class Scene
    {
        private SceneController _controller;

        protected Scene(SceneController controller)
        {
            _controller = controller;
        }

        public abstract void Start();

        public abstract void Update();

        public abstract void End();
    }
}
