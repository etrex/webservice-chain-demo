using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;

namespace HttpServerForCallback.Models
{
    public class ApiCaller
    {
        public static string JsonPost(string url, Object data)
        {
            string result = string.Empty;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    client.Timeout = new TimeSpan(0, 0, 30);
                    HttpResponseMessage apiResult;

                    string json = data.ToJson();
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    apiResult = client.PostAsync(url, content).Result;

                    result = apiResult.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            {
                result = ex.StackTrace;
            }
            return result;
        }

        public static string Get(string url, Object data)
        {
            string result = string.Empty;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = new TimeSpan(0, 0, 30);
                    HttpResponseMessage apiResult;
                    UriBuilder urlBuilder = new UriBuilder(url);
                    urlBuilder.Query = data.ToQueryString();
                    apiResult = client.GetAsync(urlBuilder.Uri).Result;
                    result = apiResult.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            {
                result = ex.StackTrace;
            }
            return result;
        }
    }
}