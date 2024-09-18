using Helpers;

namespace Models
{
    public class GameState : StateModel<Game.State>
    {
        public GameState()
            : base(Game.State.Home) { }
    }
}
