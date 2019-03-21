using MedievalIO.Domain.Unit.Behaviours;
using MedievalIO.Domain.Unit.Properties;

namespace MedievalIO.Domain.Unit.Units
{
    public class Knight : IUnit
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public IHealth Health { get; }
        public IAttack Attack { get; }
        public IDefend Defend { get; }

        public Knight(IDefend defend, IAttack attack, IHealth health)
        {
            Defend = defend;
            Attack = attack;
            Health = health;
        }
    }
}