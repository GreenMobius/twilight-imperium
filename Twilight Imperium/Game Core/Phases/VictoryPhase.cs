namespace Game_Core.Phases
{
  public class VictoryPhase : GamePhase
  {
    public VictoryPhase(GameContext context) : base(context)
    {
      GameContext.Playing = false;
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
      return;
    }
  }
}