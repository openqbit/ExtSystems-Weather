using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Weather.Common.Models
{
    public class Forecast
    {
        public int Id { get; set; }
       // public int HourID { get; set; }
        public int CountryId { get; set; }
        public int DaydetailId { get; set; }
        public DateTime Date { get; set; }
      //  public string Temperature { get; set; }
        public string Status { get; set; }
       // public string Wind { get; set; }
        public virtual ICollection<Forecastdetail> Forecastdetail { get; set; }


    }
}
