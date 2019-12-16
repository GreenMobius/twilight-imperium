namespace Game_Core.Phases
{
  public abstract class GameState
  {
    private GameContext GameContext { get; set; }
    private Player ActivePlayer { get; set; }

    public GameState(GameContext context, Player player)
    {
      GameContext = context;
      ActivePlayer = player;
    }
  }
}