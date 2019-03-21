namespace MedievalIO.Domain.Unit.Properties
{
    public class Health : IHealth
    {
        public int HealthPoints { get; set; }
        public int MaxHealthPoints { get; set; }

        public Health(int maxHealthPoints)
        {
            MaxHealthPoints = maxHealthPoints;
            HealthPoints = maxHealthPoints;
        }
    }
}