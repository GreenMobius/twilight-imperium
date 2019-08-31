using System.Collections.Generic;

namespace Game_Core.Phases
{
  public abstract class GamePhase
  {
    protected readonly GameContext GameContext;
    protected GameState CurrentState;
    protected List<GameState> States;

    protected GamePhase(GameContext context)
    {
      GameContext = context;
      States = new List<GameState>();
    }

    public abstract void StartPhase();
    public abstract bool RunPhase();
    public abstract void EndPhase();
  }
}