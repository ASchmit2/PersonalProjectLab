using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;
namespace PersonalProjectLabTests
{
    [TestClass]
    public class MileageCalculatorTest
    {
        [TestMethod]

        public void TestMilesToEmpty()
        {
            double mileage = 20;
            double tankSize = 10;
            double fuelLevel = .5;

            MileageCalculator engine = new MileageCalculator();

            double result = engine.MilesToEmpty(mileage, tankSize, fuelLevel);

            Assert.AreEqual(result, 100);
        }

        [TestMethod]
        public void TestMilesToEmpty2()
        {
            double milesPerTank = 400;
            double fuelLevel = .5;

            MileageCalculator engine = new MileageCalculator();

            double result = engine.MilesToEmpty2(milesPerTank, fuelLevel);

            Assert.AreEqual(result, 200);
        }

        [TestMethod]
        public void TestCalculateMileage()
        {
            double tankSize = 10;
            double milesPerTank = 400;

            MileageCalculator engine = new MileageCalculator();

            double result = engine.CalculateMileage(milesPerTank, tankSize);

            Assert.AreEqual(result, 40);
        }
    }
}
