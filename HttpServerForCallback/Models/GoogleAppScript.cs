using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HttpServerForCallback.Models
{
    public class GoogleAppScript
    {
        // https://developers.google.com/apps-script/
        // step by step tutorial http://blog.jim60105.com/2015/06/google-database.html 
        // please build a api to send message to google sheets through http get method
        public static string webHookUrl = "put your google app script api url there";

        public static string Send(Object data)
        {
            return ApiCaller.Get(webHookUrl, data);
        }
    }
}