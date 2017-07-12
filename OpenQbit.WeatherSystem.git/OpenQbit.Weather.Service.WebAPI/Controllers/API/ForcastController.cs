using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using OpenQbit.Weather.Service.WebAPI.Models;

namespace OpenQbit.Weather.Service.WebAPI.Controllers.API
{
    public class ForcastController : ApiController
    {
        public ForcastModel Get(int id)
        {
            ForcastModel forcast = new ForcastModel
            {
                Id = 1,
                CountryId = 1,
                DaydetailId = 1,
                Date = new DateTime(12 - 07 - 2017),
                Status = "Cloudy"
            };
            return forcast;
        }
        public List<ForcastModel> getList()
        {
            List<ForcastModel> ForcastList = new List<ForcastModel>();

            ForcastModel forcast1 = new ForcastModel
            {
                Id = 1,
                CountryId = 1,
                DaydetailId = 1,
                Date = new DateTime(12 - 07 - 2017),
                Status = "Cloudy"
            };

            ForcastModel forcast2 = new ForcastModel()
            {
                Id = 1,
                CountryId = 1,
                DaydetailId = 1,
                Date = new DateTime(12 - 07 - 2017),
                Status = "Cloudy"
            };
            ForcastList.Add(forcast1);
            ForcastList.Add(forcast2);

            return ForcastList;
        }
    }
}

