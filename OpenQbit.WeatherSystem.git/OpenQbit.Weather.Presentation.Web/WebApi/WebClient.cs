using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Net.Http;
using OpenQbit.Weather.Presentation.Web.Models;
using System.Web.Script.Serialization;
using System.Threading.Tasks;

namespace OpenQbit.Weather.Presentation.Web.WebApi
{
    public class WebClient
    {
        HttpClient _client;
        JavaScriptSerializer _jsonSerializer = new JavaScriptSerializer();

        public WebClient()
        {
            _client = new HttpClient();
        }
        public async Task<CountryModel> GetCountry()
        {
            CountryModel country = new CountryModel();

            using (var response = await _client.GetAsync("http://localhost:51279/api/CountryModel/1"))
            {
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    country = _jsonSerializer.Deserialize<CountryModel>(jsonString);
                }
            }


            return country;

        }
        public async Task<DayDetailsModel> GetDayDetail()
        {
            DayDetailsModel dayDetail = new DayDetailsModel();

            using (var response = await _client.GetAsync("http://localhost:51279/api/CountryModel/1"))
            {
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    dayDetail = _jsonSerializer.Deserialize<DayDetailsModel>(jsonString);
                }
            }


            return dayDetail;
        }
        public async Task<ForcastDetailModel> GetForcastDetail()
        {
            ForcastDetailModel forcastDetail = new ForcastDetailModel();

            using (var response = await _client.GetAsync("http://localhost:51279/api/CountryModel/1"))
            {
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    forcastDetail = _jsonSerializer.Deserialize<ForcastDetailModel>(jsonString);
                }
            }


            return forcastDetail;
        }
        public async Task<ForcastModel> GetForcast()
        {
            ForcastModel forcast = new ForcastModel();

            using (var response = await _client.GetAsync("http://localhost:51279/api/CountryModel/1"))
            {
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    forcast = _jsonSerializer.Deserialize<ForcastModel>(jsonString);
                }
            }


            return forcast;
        }
    }
}