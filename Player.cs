public abstract class Player
{
    public string Name { get; set; }
    public char Symbol { get; set; }

    public abstract int GetMove();
}