using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Weather.Presentation.Web.Models
{
    public class ForcastModel
    {
        public int Id { get; set; }
        
        public int CountryId { get; set; }
        public int DaydetailId { get; set; }
        public DateTime Date { get; set; }
        
        public string Status { get; set; }
        
    }
}