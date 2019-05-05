namespace MedievalIO.Domain.Unit.Statistics
{
    public interface IHealth : IStatistic
    {
        int HealthPoints { get; }
        int MaxHealthPoints { get; }
    }
}