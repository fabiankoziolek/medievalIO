using System;
using System.Collections.Generic;
using MedievalIO.Domain.Map.Resource;
using MedievalIO.Domain.Unit.Behaviours;
using MedievalIO.Domain.Unit.Statistics;

namespace MedievalIO.Domain.Unit
{
    public abstract class Unit : IUnit
    {
        public string Name { get; protected set; }
        public string ShortName { get; protected set; }
        public IList<IStatistic> Statistics { get; set; }
        public IList<IEquipable> Equipment { get; set; }
        public SortedList<IResource, int> Cost { get; set; }

        public Unit()
        {
            Equipment = new List<IEquipable>();
            Cost = new SortedList<IResource, int>();
            Statistics = new List<IStatistic>();
        }

        public void SetAttack(IStrength strength)
        {
            throw new NotImplementedException();
        }

        public void SetDefence(IDefensive defence)
        {
            throw new NotImplementedException();
        }

        public void SetHealth(IHealth health)
        {
            throw new NotImplementedException();
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Defend()
        {
            throw new NotImplementedException();
        }

        public IUnit Build => this;
    }
}