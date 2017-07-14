using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Weather.Service.WebAPI.Models
{
    public class ForcastDetailModel
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public string Temperature { get; set; }
        public string Windspeed { get; set; }
        public int ForecastId { get; set; }
        public string Status { get; set; }

    }
}