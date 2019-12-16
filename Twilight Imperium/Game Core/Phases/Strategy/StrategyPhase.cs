using System.Collections.Generic;
using System.Linq;

namespace Game_Core.Phases.Strategy
{
  public class StrategyPhase : GamePhase
  {
    private bool Repeat { get; set; }
    
    public StrategyPhase(GameContext context) : base(context) { }

    public override void StartPhase()
    {
      Repeat = GameContext.NumPlayers <= 4;
      var playerList = GameContext.PlayersBySpeaker();
      if (Repeat)
      {
        playerList = playerList.Concat(GameContext.PlayersBySpeaker());
      }
      foreach (var player in playerList)
      {
        States.Add(new StrategyCardSelectionState(GameContext, player));
      }
    }

    public override bool RunPhase()
    {
      if (States.Count == 0)
      {
        return false;
      }
      CurrentState = States[0];
      States.RemoveAt(0);
      return true;
    }

    public override void EndPhase()
    {
      GameContext.TransitionTo(new StrategyPhase(GameContext));
    }
  }
}