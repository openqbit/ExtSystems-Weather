using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Weather.Common.Models
{
    public class Daydetail
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
