using MedievalIO.Domain.Common;
using MedievalIO.Domain.Unit.Behaviours;
using MedievalIO.Domain.Unit.Properties;

namespace MedievalIO.Domain.Unit
{
    public interface IUnit : INameable
    {
        IHealth Health { get; }
        IAttack Attack { get; }
        IDefend Defend { get; }
    }
}