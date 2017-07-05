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

        }

        public void InsertForecastTest()
        {

        }

        public void InsertForecastdetailTest()
        {

        }
    }
}
