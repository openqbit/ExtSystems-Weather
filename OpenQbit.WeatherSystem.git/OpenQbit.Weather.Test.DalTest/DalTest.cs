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
            Daydetail daydetail = new Daydetail
            {

                DayDescription = "DayDetail"


            };

            _db.Daydetail.Add(daydetail);
            _db.SaveChanges();

            Daydetail dbDayDetail = _db.Daydetail.Where(c => c.DayDescription == "DayDetail").FirstOrDefault();

            string actual, expected;

            actual = dbDayDetail.DayDescription;
            expected = "DayDetail";

            Assert.AreEqual(expected, actual);

            _db.Daydetail.Remove(dbDayDetail);

        }

        public void InsertForecastTest()
        {
            Forecast forcast = new Forecast
            {

                Status = "Forcats"


            };

            _db.Forecast.Add(forcast);
            _db.SaveChanges();

            Forecast dbForcast = _db.Forecast.Where(c => c.Status == "Forcast").FirstOrDefault();

            string actual, expected;

            actual = dbForcast.Status;
            expected = "DayDetail";

            Assert.AreEqual(expected, actual);

            _db.Forecast.Remove(dbForcast);

        }

        public void InsertForecastdetailTest()
        {

            Forecastdetail forcastDetails = new Forecastdetail
            {

                Temperature = "ForcatsDetails"



            };

            _db.Forecastdetail.Add(forcastDetails);
            _db.SaveChanges();

            Forecastdetail dbForcastDetils = _db.Forecastdetail.Where(c => c.Temperature == "ForcastDetails").FirstOrDefault();

            string actual, expected;

            actual = dbForcastDetils.Status;
            expected = "ForcastDetail";

            Assert.AreEqual(expected, actual);

            _db.Forecastdetail.Remove(dbForcastDetils);

        }
    }
}
