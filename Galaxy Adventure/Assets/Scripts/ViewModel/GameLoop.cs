using Interfaces;

namespace ViewModel
{
    class GameLoop
    {
        public GameLoop(IGame game)
        {
            game.GameTick += Game_Tick;
        }
        void Game_Tick(object sender, double deltaTime)
        {

        }
    }
}