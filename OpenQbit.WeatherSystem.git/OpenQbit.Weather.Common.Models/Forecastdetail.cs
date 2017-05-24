using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Weather.Common.Models
{
    public class Forecastdetail
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public string Temperature { get; set; }
        public string Windspeed { get; set; }

        public int ForecastId { get; set; }
        public string Status { get; set; }

        public virtual Forecast Forecast { get; set; }
    }
}
