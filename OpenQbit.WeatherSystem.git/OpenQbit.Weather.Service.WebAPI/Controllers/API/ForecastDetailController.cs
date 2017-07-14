using OpenQbit.Weather.Service.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OpenQbit.Weather.Service.WebAPI.Controllers.API
{
    public class ForecastDetailController : ApiController
    {
        public ForecastDetailModel Get(int id)
        {
            ForecastDetailModel forecastetail = new ForecastDetailModel
            {
                Id = 1,
                Time = new DateTime(2017,07,11),
                Temperature = "30c",
                Windspeed = "26km/h",
                ForecastId = 1,
                Status="The skies will be mostly cloudy"
            };

            return forecastetail;
        }

        public List<ForecastDetailModel> GetList()
        {
            List<ForecastDetailModel> forecastdetailList = new List<ForecastDetailModel>();

            ForecastDetailModel forecastdetail1 = new ForecastDetailModel
            {
                Id = 1,
                Time = new DateTime(2017, 07, 11),
                Temperature = "30c",
                Windspeed = "26km/h",
                ForecastId = 1,
                Status = "The skies will be mostly cloudy"
            };

            ForecastDetailModel forecastdetail2 = new ForecastDetailModel
            {
                Id = 2,
                Time = new DateTime(2017, 07, 12),
                Temperature = "28c",
                Windspeed = "29km/h",
                ForecastId = 2,
                Status = "The skies will be mostly rainy"
            };

            forecastdetailList.Add(forecastdetail1);
            forecastdetailList.Add(forecastdetail2);

            return forecastdetailList;
        }
    }
}

