namespace Dependencies
{
    public class Customer
    {
        public Customer(Level level, int points)
        {
            Level = level;
            Points = points;
        }

        public Level Level { get; private set; }
        public int Points { get; private set; }
    }
}