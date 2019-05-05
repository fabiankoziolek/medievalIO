using System.Collections.Generic;
using MedievalIO.Domain.Unit;
using MedievalIO.Domain.Unit.Statistics;

namespace MedievalIO.Units.Engine.UnitBuilders
{
    public class UnitBuilder : IUnitBuilder
    {
        private IBuildable _unit;

        public IUnitBuilder SetUnit(IUnit unit)
        {
            _unit = unit;
            return this;
        }

        public IUnitBuilder SetEquipment(IList<IEquipable> equipment)
        {
            _unit.Build.Equipment = equipment;
            return this;
        }

        public IUnitBuilder SetHealth(IHealth health)
        {
            _unit.Build.Statistics.Add(health);
            return this;
        }

        public IUnitBuilder SetAttack(IStrength strength)
        {
            _unit.Build.Statistics.Add(strength);
            return this;
        }

        public IUnitBuilder SetDefence(IDefence defence)
        {
            _unit.Build.Statistics.Add(defence);
            return this;
        }

        public IUnit GetUnit()
        {
            return (IUnit) _unit;
        }
    }
}