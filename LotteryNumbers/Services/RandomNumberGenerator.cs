using LotteryNumbers.Models;
using System;
using System.Collections.Generic;


namespace LotteryNumbers.Services
{
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        // If I have more time. I will crate IRules. It will have three Rules Classes.
        // DuplicateValueRule, SequenceLengthRule, BackGroundColorRule and inject them
        // through dependency injections

        public LotteryNumbersDto GetRandomNumbers(int length, int minNumber, int maxNumber)
        {
            if (minNumber >= maxNumber)
                throw new ArgumentOutOfRangeException("minValue must be lower than maxNumber");

            var randomNumberList = new List<int>();
            var randomNumber = 0;
            Random random = new Random();
            while (randomNumberList.Count != length)
            {
                randomNumber = random.Next(minNumber, maxNumber);
                if (!randomNumberList.Contains(randomNumber)) randomNumberList.Add(randomNumber);
            }

            randomNumberList.Sort();
            var lotteryNumbersDto = new LotteryNumbersDto()
            {
                LotteryNumbers = randomNumberList
            };
            return lotteryNumbersDto;
        }
    }
}
