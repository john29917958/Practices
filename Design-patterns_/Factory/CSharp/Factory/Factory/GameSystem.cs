using System;
using Factory.Factories;

namespace Factory
{
    public static class GameSystem
    {
        public static bool IsHardMode
        {
            get { return _isHardMode; }
            set
            {
                Console.WriteLine("==================" + Environment.NewLine +
                                  "Set game mode to " + (_isHardMode ? "hard" : "normal") + Environment.NewLine +
                                  "==================");

                _isHardMode = value;

                if (IsHardMode)
                {
                    NpcFactory = new HardNpcFactory();
                }
                else
                {
                    NpcFactory = new DefaultNpcFactory();
                }
            }
        }

        private static bool _isHardMode;

        public static INpcFactory NpcFactory { get; private set; } = new DefaultNpcFactory();
    }
}