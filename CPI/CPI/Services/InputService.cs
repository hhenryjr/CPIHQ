using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

using dotnetCloudantWebstarter.Models;
using Newtonsoft.Json;
using System.Text;

namespace dotnetCloudantWebstarter.Services
{
    public class InputService
    {
        

        public static ContentResult GetInput(string url)
        {
            var client = new HttpClient();

            var response = client.GetAsync(url).Result;

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

        public static string ParseContent(string content)
        {
            InputResult result = JsonConvert.DeserializeObject<InputResult>(content);

            //result.collection1 = JsonConvert.DeserializeObject<List<TwitterPost>>(result.results);

            StringBuilder resultString = new StringBuilder();

            foreach(TwitterPost post in result.results.collection1)
            {
                resultString.Append(post.tweet);
            }

            return resultString.ToString();
        }

    }
}
