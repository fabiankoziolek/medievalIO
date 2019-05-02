using MedievalIO.Domain.Unit.Behaviours;
using MedievalIO.Domain.Unit.Properties;

namespace MedievalIO.Domain.Unit
{
    public abstract class Unit : IUnit, IBuildable
    {
        public string Name { get; protected set; }
        public string ShortName { get; protected set; }
        
        public IHealth Health { get; private set; }
        public IAttack Attack { get; private set; }
        public IDefend Defend { get; private set; }
        
        public void SetAttack(IAttack attack)
        {
            Attack = attack;
        }

        public void SetDefence(IDefend defence)
        {
            Defend = defence;
        }

        public void SetHealth(IHealth health)
        {
            Health = health;
        }
    }
}