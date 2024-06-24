using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabWorkFunctions.Tests
{
    [TestClass()]
    public class FunctionsTests
    {
        [TestMethod()]
        [DataTestMethod()]
        [DataRow(0, 1ul)]
        [DataRow(1, 1ul)]
        [DataRow(5, 120ul)]
        public void FactorialTest_CorrectValues(int n, ulong expected)
        {
            Assert.AreEqual(expected, Functions.GetFactorial(n));
        }

        [TestMethod()]
        public void FactorialTest_IncorrectValues()
        {
            Assert.AreEqual(0ul, Functions.GetFactorial(-1));
        }

        [TestMethod()]
        [DataTestMethod()]
        [DataRow(1.5, 2, 2.25)]
        [DataRow(2, 15, 32768)]
        public void PowerTest_PositivePower(double x, int n, double expected)
        {
            Assert.AreEqual(expected, Functions.GetPower(x, n), 0.001);
        }

        [TestMethod()]
        [DataTestMethod()]
        [DataRow(2.5, -3, 0.064)]
        [DataRow(2, -4, 0.0625)]
        public void PowerTest_NegativePower(double x, int n, double expected)
        {
            Assert.AreEqual(expected, Functions.GetPower(x, n), 0.001);
        }

        [TestMethod()]
        [DataTestMethod()]
        [DataRow(2, 2, 4)]
        [DataRow(2, 15, 32768)]
        [DataRow(2, 0, 1)]
        public void GetFastPower_CorrectValues(double x, int n, double expected)
        {
            Assert.AreEqual(expected, Functions.GetFastPower(x, n), 0.001);
        }

        [TestMethod()]
        [DataTestMethod()]
        [DataRow(2, -1, -1)]
        public void GetFastPower_IncorrectValuesValue(double x, int n, double expected)
        {
            Assert.AreEqual(expected, Functions.GetFastPower(x, n), 0.001);
        }
    }
}