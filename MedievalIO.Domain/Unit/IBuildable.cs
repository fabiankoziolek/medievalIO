using MedievalIO.Domain.Unit.Behaviours;
using MedievalIO.Domain.Unit.Properties;

namespace MedievalIO.Domain.Unit
{
    public interface IBuildable
    {
        void SetAttack(IAttack attack);
        void SetDefence(IDefend defence);
        void SetHealth(IHealth health);
    }
}