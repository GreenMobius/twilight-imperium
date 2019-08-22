using System;
using Game_Core.States;

namespace Game_Core
{
  public class GameContext
  {
    private GameState State { get; set; }
    public int NumPlayers { get; private set; }
    public bool Playing { get; set; }
    public int PlayerId { get; set; }

    public GameContext(int players)
    {
      Init(players, new StartState(this));
    }
    
    public GameContext(int players, GameState state)
    {
      Init(players, state);
    }

    private void Init(int players, GameState state)
    {
      NumPlayers = players;
      State = state;
      Playing = true;
      PlayerId = 0;
    }

    public void Next()
    {
      State.AdvancePlayer();
    }

    public string Status()
    {
      return $"Players: {NumPlayers}, State: {State}, Active: {PlayerId}";
    }

    public void TransitionTo(GameState state)
    {
      Console.WriteLine($"Moving from state {State} to state {state}");
      State = state;
    }
  }

  public abstract class GameState
  {
    protected GameContext GameContext { get; }

    protected GameState(GameContext context)
    {
      GameContext = context;
    }

    public abstract void AdvancePlayer();
  }
}