using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace dotnetCloudantWebstarter.Services
{
    public class TwitterService
    {
        public static ContentResult GetTweetsByUser(string userHandle)
        {
            
         var username = "60192d7f-17fe-4649-a210-847685632678";
            var password = "dq3t9TsaB7";

            //var basePath = "https://gateway.watsonplatform.net/personality-insights/api/v2/profile";
            //var basePath = "https://"+username+":"+password+"@cdeservice.mybluemix.net:443/api/v1/tracks";
          var basePath = "https://cdeservice.mybluemix.net:443/api/v1/messages/search"; // example query ?q=from%3AShaneMosley_&from=0&size=1"




            string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", username, password)));

            var client = new HttpClient();

            client.DefaultRequestHeaders.Authorization =
                 new AuthenticationHeaderValue(
                    "Basic",
                    Convert.ToBase64String(
                        System.Text.ASCIIEncoding.ASCII.GetBytes(
                              string.Format("{0}:{1}", username, password))));

            string apiPath = basePath + "?q=from:" + userHandle + "&from=0&size=500";

            var response = client.GetAsync(apiPath).Result;

            var result = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                var contentResult = new ContentResult
                {
                    // ContentType = "application/json",
                    Content = response.ReasonPhrase
                };
                return contentResult;
            }

            var successResult = new ContentResult
            {
                //ContentType = "application/json",
                Content = result
            };

            return successResult;
        }

        public static string ParseResults(string jsonString)
        {
            string startPattern = "},\"body\":\"";
            string endPattern = "\",\"favoritesCount\":";


            StringBuilder messageString = new StringBuilder();

            while(jsonString.IndexOf(startPattern)>=0 && jsonString.IndexOf(startPattern)<jsonString.Length)
            {
                int startIndex = jsonString.IndexOf(startPattern) + startPattern.Length;

                jsonString = jsonString.Substring(startIndex);
                startIndex = 0;

                int endIndex = jsonString.IndexOf(endPattern);
                string message = jsonString.Substring(startIndex, endIndex - startIndex - 2);

                messageString.Append(message+" ");
                jsonString = jsonString.Substring(endIndex+1);
            }
            

            return messageString.ToString(); 
        }
    }
}
