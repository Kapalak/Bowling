namespace BowlingGameCore
{
    public class Frame
    {
        public int index { get; set; }

        public List<int> Rolls { get; set; } = new List<int>();

        public bool Closed { get; set; }
    }
}
