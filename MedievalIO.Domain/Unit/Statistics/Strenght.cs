namespace MedievalIO.Domain.Unit.Statistics
{
    public class Strength : IStrength
    {
        public int StrengthPoints { get; }

        public Strength(int strengthPoints)
        {
            StrengthPoints = strengthPoints;
        }
    }
}