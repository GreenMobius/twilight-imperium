using System;
using System.Collections.Generic;
using System.Linq;
using Game_Core.Phases;

namespace Game_Core
{
  public class GameContext
  {
    private GamePhase Phase { get; set; }
    private List<Player> Players { get; set; }
    public int NumPlayers => Players.Count;
    public bool Playing { get; set; }

    public GameContext(List<Player> players)
    {
      Init(players, new StartPhase(this));
    }
    
    public GameContext(List<Player> players, GamePhase phase)
    {
      Init(players, phase);
    }

    private void Init(List<Player> players, GamePhase phase)
    {
      Players = players;
      Phase = phase;
      Playing = true;
    }

    public string Status()
    {
      return $"State: {Phase}";
    }

    public void TransitionTo(GamePhase phase)
    {
      Console.WriteLine($"Moving from state {Phase} to state {phase}");
      Phase = phase;
    }

    public IEnumerable<Player> PlayersByInitiative()
    {
      yield return null;
    }

    public IEnumerable<Player> PlayersBySpeaker() 
    {
      var startIndex = 0;
      for (;;startIndex++) { if (Players[startIndex].Speaker) { break; } }

      for (var i = 0; i < NumPlayers; i++)
      {
        yield return Players[(i + startIndex) % NumPlayers];
      }}
    
    public IEnumerable<Player> PlayersByPlayer(Player p)
    {
      var startIndex = 0;
      for (;;startIndex++) { if (Players[startIndex].Equals(p)) { break; } }

      for (var i = 0; i < NumPlayers; i++)
      {
        yield return Players[(i + startIndex) % NumPlayers];
      }
    }
  }
}