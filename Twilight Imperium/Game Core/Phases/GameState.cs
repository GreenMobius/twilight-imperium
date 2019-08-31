namespace Game_Core.Phases
{
  public abstract class GameState
  {
    protected GameContext GameContext { get; set; }
    protected Player ActivePlayer { get; set; }

    public GameState(GameContext context, Player player)
    {
      GameContext = context;
      ActivePlayer = player;
    }
  }
}