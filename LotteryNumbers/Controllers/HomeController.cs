using System;
using LotteryNumbers.Services;
using System.Web.Mvc;

namespace LotteryNumbers.Controllers
{
    public class HomeController : Controller
    {
        private IRandomNumberGenerator _randomNumberGenerator;

        public HomeController(IRandomNumberGenerator randomNumberGenerator)
        {            
            _randomNumberGenerator = randomNumberGenerator ?? throw new ArgumentNullException("randomNumberGenerator"); 
        }
        public ActionResult Index(int length = 6, int minNumber = 1, int maxNumber = 49)
        {
            var lotteryNumbersDto = _randomNumberGenerator.GetRandomNumbers(length, minNumber, maxNumber);
            return View(lotteryNumbersDto);
        }

    }
}