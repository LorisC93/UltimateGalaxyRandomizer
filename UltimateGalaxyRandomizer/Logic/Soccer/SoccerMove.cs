namespace UltimateGalaxyRandomizer.Logic.Soccer
{
    public class SoccerMove(Move.Move move, byte level)
    {
        public Move.Move Move { get; set; } = move;

        public byte Level { get; set; } = level;
    }
}
