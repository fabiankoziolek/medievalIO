using MedievalIO.Domain.Unit.Behaviours;
using MedievalIO.Domain.Unit.Statistics;

namespace MedievalIO.Domain.Unit
{
    public interface IBuildable
    {
        IUnit Build { get; }
    }
}