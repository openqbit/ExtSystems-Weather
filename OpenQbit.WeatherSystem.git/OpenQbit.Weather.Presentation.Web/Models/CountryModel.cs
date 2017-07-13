using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Weather.Presentation.Web.Models
{
    public class CountryModel
    {
        public int Id { get; set; }
        public string countryName { get; set; }

        /* public static implicit operator CountryModel( v)
         {
             throw new NotImplementedException();

         }*/
    }
}