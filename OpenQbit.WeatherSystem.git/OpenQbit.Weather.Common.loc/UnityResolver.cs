using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQbit.Weather.Common.Models;
using OpenQbit.Weather.DAL.DataAccess;
using OpenQbit.Weather.DAL.DataAccess.Contracts;
using OpenQbit.Weather.WeatherService;
using OpenQbit.Weather.WeatherService.Contracts;
using OpenQbit.Weather.Common.Utils.Logs;

using Microsoft.Practices.Unity;

namespace OpenQbit.Weather.Common.loc
{
    public static class UnityResolver
    {
        private static readonly IUnityContainer Container = new UnityContainer();

        private static void Register()
        {
            Container.RegisterType<IRepository, Repository>();
            Container.RegisterType<ILogger, Logger>();

            Container.RegisterType<ICountryManager, CountryManager >();
            Container.RegisterType<IDaydetailManager, DaydetailManager>();
            Container.RegisterType<IForecastManager, ForecastManager>();

        }

        public static T Resolve<T>()
        {
            T defaultT = default(T);
            var resolved = Container.Resolve<T>();
            return (resolved == null) ? defaultT : resolved;
        }

        public static IUnityContainer GetContainer()
        {
            return Container;
        }
    }
}
