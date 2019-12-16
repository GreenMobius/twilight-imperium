using Game_Core.Phases.Strategy;

namespace Game_Core.Phases
{
  public class InitPhase : GamePhase
  {    
    public InitPhase(GameContext context) : base(context)
    {
    }

    public override void StartPhase()
    {
      return;
    }

    public override bool RunPhase()
    {
      return false;
    }

    public override void EndPhase()
    {
      GameContext.TransitionTo(new StrategyPhase(GameContext));
    }
  }
}