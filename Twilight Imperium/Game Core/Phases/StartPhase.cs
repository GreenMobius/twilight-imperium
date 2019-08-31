using System.Collections.Generic;
using Game_Core.Phases.Strategy;

namespace Game_Core.Phases
{
  public class StartPhase : GamePhase
  {    
    public StartPhase(GameContext context) : base(context)
    {
    }

    public override void RunPhase()
    {
      GameContext.TransitionTo(new StrategyPhase(GameContext));
    }
  }
}