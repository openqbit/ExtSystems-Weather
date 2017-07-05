using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Weather.Presentation.Web.Models
{
    public class DayDetailsModel
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