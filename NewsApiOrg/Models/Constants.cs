using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsApiOrg.Models
{
    public class Constants
    {
        public static string NewsApiBaseUrl = "https://newsapi.org/v2";
        public static string NewsApiEverything = "/everything?q={PARAM}&apiKey={KEY}";
        public static string NewsApiKey = "de37cbb597fc453da942bcf8d00b9815";


        public static string OpenWeatherApiBaseUrl = "https://api.openweathermap.org/data/2.5";
        public static string OpenWeatherApiOneCallEndpoint = "/onecall?lat={lat}&lon={lon}&appid={APIkey}";
        //public static string OpenWeatherApiOneCallEndpoint = "/onecall?lat={lat}&lon={lon}&exclude={part}&appid={APIkey}";
        public static string OpenWeatherApiCurrentEndpoint = "/weather?q={city name}&appid={APIkey}";
        public static string OpenWeatherApiKey = "e111016c4c4dbc4ca07f9809f63095a7";
    }
}