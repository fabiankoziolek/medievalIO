using System.Collections.Generic;
using MedievalIO.Domain.Common;
using MedievalIO.Domain.Unit.Behaviours;
using MedievalIO.Domain.Unit.Statistics;

namespace MedievalIO.Domain.Unit
{
    public interface IUnit : INameable, IOffensive, IDefensive, ICostable, IBuildable
    {
        IList<IStatistic> Statistics { get; set; }
        IList<IEquipable> Equipment { get; set; }
    }
}