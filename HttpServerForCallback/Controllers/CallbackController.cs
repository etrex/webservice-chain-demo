using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using HttpServerForCallback.Models;

namespace HttpServerForCallback.Controllers
{
    public class CallbackController : ApiController
    {
        // GET: /Callback/
        [AcceptVerbs("GET", "POST")]
        public object Index()
        {
            var Request = HttpContext.Current.Request;
            var data = new
            {
                UserAgent = Request.UserAgent,
                HttpMethod = Request.HttpMethod,
                Header = Request.Headers.ToList(),
                Query = Request.QueryString.ToList(),
                Form = Request.Form.ToList(),
                File = Request.Files,
                InputStream = new StreamReader(Request.InputStream).ReadToEnd()
            };
            string slackResult = Slack.Send(data);
            string googleAppScriptResult = GoogleAppScript.Send(data);
            return new
            {
                slackResult = slackResult,
                googleAppScriptResult = googleAppScriptResult
            };
        }
    }
}