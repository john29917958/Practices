using System;
using System.Threading;
using StateMachine.Scenes;

namespace StateMachine
{
    class Program
    {
        private static bool _isAlive = true;
        private static readonly object LockObj = new object();

        static void Main(string[] args)
        {
            SceneController sceneController = new SceneController();
            Thread thread = new Thread(Update);
            thread.IsBackground = true;
            thread.Start(sceneController);

            lock (LockObj)
            {
                sceneController.SetScene(new StartScene(sceneController));
            }            

            Thread.Sleep(50);

            lock (LockObj)
            {
                sceneController.SetScene(new MenuScene(sceneController));
            }            

            Thread.Sleep(50);

            lock (LockObj)
            {
                sceneController.SetScene(new BattleScene(sceneController));
            }            

            Thread.Sleep(50);

            _isAlive = false;

            Console.ReadLine();
        }

        private static void Update(object sceneController)
        {
            SceneController controller = (SceneController) sceneController;

            while (_isAlive)
            {
                lock (LockObj)
                {
                    controller.Update();
                }                
            }
        }
    }
}
