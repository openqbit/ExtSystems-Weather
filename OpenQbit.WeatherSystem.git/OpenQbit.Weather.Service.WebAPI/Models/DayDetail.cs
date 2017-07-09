using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Weather.Service.WebAPI.Models
{
    public class DayDetail
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string DayDescription { get; set; }
        public string NightDescription { get; set; }
        public DateTime Sunrise { get; set; }
        public DateTime Sunset { get; set; }
        public DateTime Moonrise { get; set; }
        public DateTime Moonset { get; set; }
    }
}