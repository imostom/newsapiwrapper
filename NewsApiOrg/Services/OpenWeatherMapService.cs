using NewsApiOrg.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace NewsApiOrg.Services
{
    public class OpenWeatherMapService
    {
        public static OpenWeatherApiModel LoadForecast(string latitude, string longitude)
        {
            var newsData = new OpenWeatherApiModel();
            try
            {
                var client = new HttpClient();
                string requestUrl = Constants.OpenWeatherApiBaseUrl + Constants.OpenWeatherApiOneCallEndpoint.Replace("{lon}", longitude).Replace("{lat}", latitude)
                    .Replace("{APIkey}", Constants.OpenWeatherApiKey);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                var response = client.GetAsync(requestUrl).Result;

                if (response.IsSuccessStatusCode)
                {
                    var rawResult = response.Content.ReadAsStringAsync().Result;
                    if (!string.IsNullOrEmpty(rawResult))
                    {
                        newsData = JsonConvert.DeserializeObject<OpenWeatherApiModel>(rawResult);

                    }
                }
                else
                {
                    var rawResult = response.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return newsData;
        }
    }
}