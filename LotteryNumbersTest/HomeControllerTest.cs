using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LotteryNumbers;
using LotteryNumbers.Controllers;
using Moq;
using LotteryNumbers.Services;
using LotteryNumbers.Models;
using System.Web.Mvc;

namespace LotteryNumbers.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private Mock<IRandomNumberGenerator> _mockRandomNumberGenerator;

        [TestInitialize]
        public void Initialize()
        {
            _mockRandomNumberGenerator = new Mock<IRandomNumberGenerator>();
        }

        [TestMethod]
        public void RandomNumberGeneratorIsNull_ThrowArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new HomeController(null));
        }

        // If I have More time I will use Moq and Cover all controller test scnerios

        //[TestMethod]
        //public void HomeControllerIndexMethod_MakesCallToRandonNumberGenratorToGetLoterryNumbers()
        //{
        //    var homeController = CreateRandomNumberGeneratorInstance();

        //    _mockRandomNumberGenerator.Setup(x => x.GetRandomNumbers(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>())).Returns(new LotteryNumbersDto() { LotteryNumbers = new List<int>() });

        //   var result = homeController.Index(5,4,8) as ViewResult;

        //    _mockRandomNumberGenerator.Verify(x => x.GetRandomNumbers(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        //}

        private HomeController CreateRandomNumberGeneratorInstance()
        {
            return new HomeController(_mockRandomNumberGenerator.Object);
        }


    }
}
