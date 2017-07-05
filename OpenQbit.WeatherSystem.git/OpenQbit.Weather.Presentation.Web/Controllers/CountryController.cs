using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OpenQbit.Weather.Presentation.Web.Models;

namespace OpenQbit.Weather.Presentation.Web.Controllers
{
    public class CountryController :Controller
    {
        public async Task<ActionResult> Index()
        {
            WebClient client = new WebClient();
            Customer customer = await client.Get();

            return View(country);
        }
    }
}