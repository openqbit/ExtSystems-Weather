using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using OpenQbit.Weather.Service.WebAPI.Models;

namespace OpenQbit.Weather.Service.WebAPI.Controllers.API
{
    public class DayDetailsController : ApiController
    {
        public DayDetail Get(int id)
        {
            DayDetail dayDetail = new DayDetail
            {
                Id = 1,
                Date = new DateTime(12 - 07 - 2017),
                DayDescription = "Raining",
                NightDescription = "Cloudy",
                Sunrise = new DateTime(6),
                Sunset = new DateTime(5),
                Moonrise = new DateTime(7),
                Moonset = new DateTime(5)
            };
            return dayDetail;
        }
        public List<DayDetail> getList()
        {
            List<DayDetail> DayDetailsList = new List<DayDetail>();

            DayDetail dayDetails1 = new DayDetail()
            {
                Id = 1,
                Date = new DateTime(12 - 07 - 2017),
                DayDescription = "Raining",
                NightDescription = "Cloudy",
                Sunrise = new DateTime(6),
                Sunset = new DateTime(5),
                Moonrise = new DateTime(7),
                Moonset = new DateTime(5)
            };

            DayDetail dayDetails2 = new DayDetail()
            {
                Id = 1,
                Date = new DateTime(12 - 07 - 2017),
                DayDescription = "Raining",
                NightDescription = "Cloudy",
                Sunrise = new DateTime(6),
                Sunset = new DateTime(5),
                Moonrise = new DateTime(7),
                Moonset = new DateTime(5)
            };
            DayDetailsList.Add(dayDetails1);
            DayDetailsList.Add(dayDetails2);

            return DayDetailsList;
        }
    }
}
