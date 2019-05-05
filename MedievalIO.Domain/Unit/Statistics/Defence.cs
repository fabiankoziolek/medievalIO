namespace MedievalIO.Domain.Unit.Statistics
{
    public class Defence : IDefence
    {
        public int DefencePoints { get; }
        
        public Defence(int defencePoints)
        {
            DefencePoints = defencePoints;
        }

    }
}