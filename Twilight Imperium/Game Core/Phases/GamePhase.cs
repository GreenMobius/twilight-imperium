using System.Collections.Generic;

namespace Game_Core.Phases
{
  public abstract class GamePhase
  {
    protected readonly GameContext GameContext;

    protected GamePhase(GameContext context)
    {
      GameContext = context;
    }

    public abstract void RunPhase();
  }
}