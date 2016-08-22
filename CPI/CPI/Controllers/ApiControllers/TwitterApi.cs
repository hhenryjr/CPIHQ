using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

using dotnetCloudantWebstarter.Services;
using dotnetCloudantWebstarter.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace dotnetCloudantWebstarter.Controllers
{
    [Route("api")]
    public class TwitterApi : Controller
    {
        // GET api/values
        [Route("Twitter/{handle}"), HttpGet]
        public ContentResult Post(string handle)
        {
            ContentResult response = TwitterService.GetTweetsByUser(handle);

            string inputString = TwitterService.ParseResults(response.Content);

            ContentResult personality = PersonalityService.GetPersonality(inputString);

            return personality;
        }
    }
}
