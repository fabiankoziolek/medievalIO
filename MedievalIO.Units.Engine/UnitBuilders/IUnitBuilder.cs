using System.Collections.Generic;
using MedievalIO.Domain.Unit;
using MedievalIO.Domain.Unit.Statistics;

namespace MedievalIO.Units.Engine.UnitBuilders
{
    public interface IUnitBuilder
    {
        IUnitBuilder SetUnit(IUnit unit);
        IUnitBuilder SetEquipment(IList<IEquipable> equipment);
        IUnitBuilder SetHealth(IHealth health);
        IUnitBuilder SetAttack(IStrength strength);
        IUnitBuilder SetDefence(IDefence defence);
        IUnit GetUnit();
    }
}