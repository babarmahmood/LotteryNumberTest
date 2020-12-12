using LotteryNumbers.Models;

namespace LotteryNumbers.Services
{
   public interface IRandomNumberGenerator
    {
        LotteryNumbersDto GetRandomNumbers(int length, int minNumber, int maxNumber);
    }
}
