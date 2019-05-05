namespace MedievalIO.Domain.Unit.Statistics
{
    public class Attack : IAttack
    {
        public int AttackPoints { get; }

        public Attack(int attackPoints)
        {
            AttackPoints = attackPoints;
        }
    }
}