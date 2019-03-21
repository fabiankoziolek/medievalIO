using MedievalIO.Domain.Unit.Behaviours;
using MedievalIO.Domain.Unit.Properties;

namespace MedievalIO.Units.Engine.UnitBuilder
{
    public interface IUnitBuilder
    {
        IUnitBuilder SetAttack(IAttack attack);
        IUnitBuilder SetDefence(IDefend defence);
        IUnitBuilder SetHealth(IHealth health);
    }
}