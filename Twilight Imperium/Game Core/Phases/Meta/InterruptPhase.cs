namespace Game_Core.Phases
{
  public class InterruptPhase : GamePhase
  {
    private GamePhase _interruptedPhase;
    
    public InterruptPhase(GameContext context) : base(context)
    {
    }

    public override void StartPhase()
    {
      _interruptedPhase = GameContext.Phase;
    }

    public override bool RunPhase()
    {
      return false;
    }

    public override void EndPhase()
    {
      GameContext.Phase = _interruptedPhase;
    }
  }
}