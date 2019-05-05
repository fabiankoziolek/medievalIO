using System.Collections.Generic;
using System.Linq;
using MedievalIO.Domain.Unit.Equipment;
using MedievalIO.Domain.Unit.Equipment.Armours;
using MedievalIO.Domain.Unit.Statistics;
using MedievalIO.Domain.Unit.Units;
using MedievalIO.Units.Engine.UnitBuilders;
using Xunit;

namespace MedievalIO.Units.Engine.Test
{
    public class UnitBuilderTest
    {
        private readonly IUnitBuilder _unitBuilder;

        public UnitBuilderTest()
        {
            _unitBuilder = new UnitBuilder();
        }

        [Fact]
        public void Unit_ShouldHaveAName()
        {
            // Arrange

            var knight = new Knight();
            var expectedUnitName = "Knight";

            // Act

            var result = _unitBuilder.SetUnit(knight).GetUnit().Name;

            // Assert

            Assert.Equal(expectedUnitName, result);
        }

        [Fact]
        public void Unit_ShouldHaveHundredMaxHealthPoints()
        {
            // Arrange

            var knight = new Knight();
            var expectedHealthPoints = 100;
            var health = new Health(100);
            // Act

            var result = _unitBuilder.SetUnit(knight).SetHealth(health).GetUnit().Statistics
                .First(s => s.GetType().GetInterface("IHealth") == typeof(IHealth)) as IHealth;

            // Assert

            Assert.Equal(expectedHealthPoints, result.MaxHealthPoints);
        }

        [Fact]
        public void Unit_ShouldHaveEquippedLeatherArmour()
        {
            // Arrange

            var knight = new Knight();
            var expectedEquipment = new LeatherArmour();

            // Act

            var result = _unitBuilder.SetUnit(knight).SetEquipment(new List<IEquipable>() {expectedEquipment}).GetUnit()
                .Equipment.First(s => s.GetType().GetInterface("IArmour") == typeof(IArmour)) as IArmour;

            // Assert

            Assert.Equal(expectedEquipment, result);
        }

        [Fact]
        public void Unit_ShouldHaveEquippedIronSword()
        {
            // Arrange

            var knight = new Knight();
            var expectedUnitName = "Knight";

            // Act

            var result = _unitBuilder.SetUnit(knight).GetUnit().Name;

            // Assert

            Assert.Equal(expectedUnitName, result);
        }
    }
}