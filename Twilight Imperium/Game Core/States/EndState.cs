namespace Game_Core.States
{
  public class EndState : GameState
  {
    public EndState(GameContext context) : base(context)
    {
      GameContext.Playing = false;
    }
    
    public override void AdvancePlayer() { }
  }
}