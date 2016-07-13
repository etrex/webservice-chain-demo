# webservice-chain-demo

This is a demo to link webservices together.  
Using a C# ASP.NET Web API project call HttpServerForCallback to link other webservice together.  

Trello Webhook => [HttpServerForCallback](https://github.com/etrex/webservice-chain-demo/tree/master/HttpServerForCallback) => Slack Webhook  
　　　　　　　　　　　　　　　　　=> Google App Script Api => Google Sheets  

# Link Trello
1. Find a http server to setup [HttpServerForCallback](https://github.com/etrex/webservice-chain-demo/tree/master/HttpServerForCallback), and get your api url.  
2. Go to [trello sandbox](https://developers.trello.com/sandbox).  
![](/images/1.png)
3. Click the "Execute" button to get your board id.  
4. Select the "Create Webhook" tab.  
5. Replace the "idModel" value with your board id.  
6. Replace the "callbackURL" value with your api url.   
7. Click the "Execute" button send a create webhook request.

more infomation about validate : https://kijtra.com/article/trello-webhook-api-php/

# Link Slack
1. Go to [slack webhooks](https://api.slack.com/incoming-webhooks).  
2. Click "incoming webhook integration" and fill the form.  
3. Get slack webhooks from the form and paste to [HttpServerForCallback/Models/Slack.cs](https://github.com/etrex/webservice-chain-demo/blob/master/HttpServerForCallback/Models/Slack.cs).  

#Link Google Sheets
1. Go to this [step by step tutorial](http://blog.jim60105.com/2015/06/google-database.html).  
2. Replace the code with [Google App Script](https://github.com/etrex/webservice-chain-demo/tree/master/Google%20App%20Script).  
3. Get google app script api url and paste to [HttpServerForCallback/Models/GoogleAppScript.cs](https://github.com/etrex/webservice-chain-demo/blob/master/HttpServerForCallback/Models/GoogleAppScript.cs).  

