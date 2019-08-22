namespace Game_Core.States
{
  public class StartState : GameState
  {    
    public StartState(GameContext context) : base(context)
    {
    }
    
    public override void AdvancePlayer()
    {
      if (++GameContext.PlayerId < GameContext.NumPlayers) return;
      GameContext.TransitionTo(new EndState(GameContext));
    }
  }
}