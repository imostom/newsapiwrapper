using NewsApiOrg.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsApiOrg.Controllers
{
    public class NewsController : ApiController
    {
        [HttpGet]
        [Route("News/Fetch")]
        public IHttpActionResult FetchNews([FromUri]string city)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Please check request parameters");

                //var response = NewsApiOrgService.FetchNewsArticles(city);
                var response = NewsApiOrgService.GetNews2(city);
                return Ok(response);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
