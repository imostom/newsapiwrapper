using NewsApiOrg.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsApiOrg.Controllers
{
    public class WeatherController : ApiController
    {
        [HttpGet]
        [Route("Weather/OpenWeatherMap/OneCall")]
        public IHttpActionResult LoadForecast([FromUri] string longitude, string latitude)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Please check request parameters");

                //var response = NewsApiOrgService.FetchNewsArticles(city);
                var response = OpenWeatherMapService.LoadForecast(latitude, longitude);
                return Ok(response);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
