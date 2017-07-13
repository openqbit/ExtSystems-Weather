using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq.Expressions;
using System.Linq;
using OpenQbit.Weather.Common.Models;
using OpenQbit.Weather.DAL.DataAccess;

namespace OpenQbit.Weather.Test.DalTest
{
    [TestClass]
    public class DalTest
    {
        private WeatherContext _db = new WeatherContext();
        [TestMethod]
        public void InsertCountryTest()
        {
            Country country = new Country { countryName = "TestCountry" };

            _db.Country.Add(country);
            _db.SaveChanges();

            Country dbCountry = _db.Country.Where(c => c.countryName == "TestCountry").FirstOrDefault();

            string actual, expected;

            actual = dbCountry.countryName;
            expected = "TestCountry";

            Assert.AreEqual(expected, actual);
            
            _db.Country.Remove(dbCountry);

        }

        public void InsertDayDetailTest()
        {
            Daydetail dayDetails = new Daydetail { DayDescription = "TestDate" };
            _db.Daydetail.Add(dayDetails);
            _db.SaveChanges();

            Daydetail dbDayDetails = _db.Daydetail.Where(d => d.DayDescription == "TestDate").FirstOrDefault();

            string actual, expected;

            actual = dbDayDetails.DayDescription;
            expected = "Testdate";

            Assert.AreEqual(expected, actual);
            _db.Daydetail.Remove(dbDayDetails);
        }

        public void InsertForecastTest()
        {
            Forecast forcast = new Forecast { Status = "TestStatus" };
            _db.Forecast.Add(forcast);
            _db.SaveChanges();

            Forecast dbForcast = _db.Forecast.Where(s => s.Status == "TestStatus").FirstOrDefault();
            string actual, expected;

            actual = dbForcast.Status;
            expected = "TestStatus";

            Assert.AreEqual(expected, actual);
            _db.Forecast.Remove(dbForcast);
        }

        public void InsertForecastdetailTest()
        {
            Forecastdetail forcastDetails = new Forecastdetail
            {
                Temperature = "TestTemperature",
                Windspeed = "TestWindSpeed",
               
            };
            _db.Forecastdetail.Add(forcastDetails);
            _db.SaveChanges();

            Forecastdetail dbForcastDetails = _db.Forecastdetail.Where(fd => fd.Temperature == "TestTemperature").FirstOrDefault();
            string actual, expected;

            actual = dbForcastDetails.Status;
            expected = "TestWeather";

            Assert.AreEqual(expected, actual);
            _db.Forecastdetail.Remove(dbForcastDetails);
        }
    }
}
