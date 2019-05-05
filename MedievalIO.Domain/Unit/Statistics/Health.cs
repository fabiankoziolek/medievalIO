namespace MedievalIO.Domain.Unit.Statistics
{
    public class Health : IHealth
    {
        public int HealthPoints { get; }
        public int MaxHealthPoints { get; }

        public Health(int maxHealthPoints)
        {
            MaxHealthPoints = maxHealthPoints;
            HealthPoints = maxHealthPoints;
        }
    }
}