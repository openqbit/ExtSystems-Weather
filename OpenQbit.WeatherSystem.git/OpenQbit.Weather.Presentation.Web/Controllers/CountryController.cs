using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Threading.Tasks;
using OpenQbit.Weather.Presentation.Web.Models;
using OpenQbit.Weather.Presentation.Web.WebApi;

namespace OpenQbit.Weather.Presentation.Web.Controllers
{
    public class CountryController :Controller
    {
        public async Task<ActionResult> Index()
        {
            WebClient client = new WebClient();
            CountryModel country = await client.GetCountry();

            return View(country);
        }
    }
}