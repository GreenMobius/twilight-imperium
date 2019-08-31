using System.Collections.Generic;

namespace Game_Core.Phases
{
  public class EndPhase : GamePhase
  {
    public EndPhase(GameContext context) : base(context)
    {
      GameContext.Playing = false;
    }

    public override void RunPhase()
    {
      return;
    }
  }
}