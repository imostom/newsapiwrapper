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
    }
}