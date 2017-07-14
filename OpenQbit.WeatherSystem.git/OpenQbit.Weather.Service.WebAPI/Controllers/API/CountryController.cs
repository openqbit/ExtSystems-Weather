using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

using OpenQbit.Weather.Service.WebAPI.Models;

namespace OpenQbit.Weather.Service.WebAPI.Controllers.API
{
    public class CountryController :ApiController
    {
        public CountryModel Get(int id)
        {
            CountryModel country = new CountryModel
            {
                Id = 1,
                countryName = "SriLanka"
            };
            return country;
        }
        public List<CountryModel>getList()
        {
            List<CountryModel> countryList = new List<CountryModel>();

            CountryModel country1 = new CountryModel
            {
                Id = 1,
                countryName = "SriLanka"
            };

            CountryModel country2 = new CountryModel()
            {
                Id = 2,
                countryName = "India"
            };
            countryList.Add(country1);
            countryList.Add(country2);

            return countryList;
        }
    }
}