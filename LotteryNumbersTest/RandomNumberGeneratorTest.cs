using LotteryNumbers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LotteryNumbersTest
{
    [TestClass]
    public class RandomNumberGeneratorTest
    {

        [TestMethod]
        public void RandomNumberGeneratorMinNumberIsGreaterThanMaxNumber_ThrowArgumentOutOfRangeException()
        {
            var randomNumberGenerator = new RandomNumberGenerator();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => randomNumberGenerator.GetRandomNumbers(5, 4, 2));
        }

        [TestMethod]
        public void RandomNumberGeneratorMinNumberIsOne_RetuenListWillHaveNoIntegerLessThanOne()
        {
            var randomNumberGenerator = new RandomNumberGenerator();
            var result = randomNumberGenerator.GetRandomNumbers(2, 1, 5);

            Assert.IsTrue(result.LotteryNumbers[0] >= 1);
            Assert.IsTrue(result.LotteryNumbers[1] >= 1);
        
        }

        [TestMethod]
        public void RandomNumberGeneratorMaxNumberIsFive_RetuenListWillHaveNoIntegerGreaterThanFive()
        {
            var randomNumberGenerator = new RandomNumberGenerator();
            var result = randomNumberGenerator.GetRandomNumbers(2, 1, 5);

            Assert.IsTrue(result.LotteryNumbers[0] <= 5);
            Assert.IsTrue(result.LotteryNumbers[1] <= 5);

        }

        [TestMethod]
        public void RandomNumberGeneratorSequenceLengthIsFive_RetuenListWithFiveRandomNumbers()
        {
            var randomNumberGenerator = new RandomNumberGenerator();
            var result = randomNumberGenerator.GetRandomNumbers(5, 1, 50);

            Assert.AreEqual(result.LotteryNumbers.Count, 5);

        }

        [TestMethod]
        public void RandomNumberGeneratorSequenceLengthIsTen_RetuenListWithTenRandomNumbers()
        {
            var randomNumberGenerator = new RandomNumberGenerator();
            var result = randomNumberGenerator.GetRandomNumbers(10, 1, 50);

            Assert.AreEqual(result.LotteryNumbers.Count, 10);

        }
    }
}
