using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HttpServerForCallback.Models
{
    public class Slack
    {
        //please go to https://api.slack.com/incoming-webhooks
        //to get the url.
        public static string webHookUrl = "put your slack webhook url there";

        public static string Send(Object data)
        {
            return ApiCaller.JsonPost(webHookUrl, new{
                text = data.ToJson()
            });
        }
    }
}