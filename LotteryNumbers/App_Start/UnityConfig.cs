using LotteryNumbers.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace LotteryNumbers
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IRandomNumberGenerator, RandomNumberGenerator>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}