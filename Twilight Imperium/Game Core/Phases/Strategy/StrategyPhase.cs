using System.Collections.Generic;

namespace Game_Core.Phases.Strategy
{
  public class StrategyPhase : GamePhase
  {
    private bool Repeat { get; set; }
    
    public StrategyPhase(GameContext context) : base(context) { }

    public override void RunPhase()
    {
      Repeat = GameContext.NumPlayers <= 4;
      var continuation = new List<GamePhase>();
      foreach (var player in GameContext.PlayersBySpeaker())
      {
        continuation.Add(new StrategyCardSelectionState(GameContext, player));
      }
      
      GameContext.TransitionTo(new StrategyPhase(GameContext));
    }
  }
}