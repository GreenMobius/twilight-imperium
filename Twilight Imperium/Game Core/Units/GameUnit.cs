namespace Game_Core.Units
{
  public interface IGameUnit
  {
    int Attack { get; }
    int Cost { get; }
    int Move { get; }
    int Weight { get; }
    int Production { get; }
  }
}