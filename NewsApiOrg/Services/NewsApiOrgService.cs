using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;
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
    public class NewsApiOrgService
    {
        public static ArticlesResult FetchNewsArticles(string keyword)
        {
            var articlesResponse = new ArticlesResult();
            try
            {
                var newsApiClient = new NewsApiClient("de37cbb597fc453da942bcf8d00b9815");
                articlesResponse = newsApiClient.GetEverything(new EverythingRequest
                {
                    Q = "Apple",
                    SortBy = SortBys.Popularity,
                    Language = Languages.EN,
                    From = new DateTime(2018, 1, 25)
                });
                //if (articlesResponse.Status == Statuses.Ok)
                //{
                   
                //}
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return articlesResponse;
        }


        public static NewsApiModel GetNews2(string keyword)
        {
            var newsData = new NewsApiModel();
            try
            {
                var client = new HttpClient();
                string requestUrl = Constants.NewsApiBaseUrl + Constants.NewsApiEverything.Replace("{PARAM}", keyword).Replace("{KEY}", Constants.NewsApiKey);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                var response = client.GetAsync(requestUrl).Result;

                if (response.IsSuccessStatusCode)
                {
                    var rawResult = response.Content.ReadAsStringAsync().Result;
                    if (!string.IsNullOrEmpty(rawResult))
                    {
                        newsData = JsonConvert.DeserializeObject<NewsApiModel>(rawResult);

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