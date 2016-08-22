using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CPI.Services;
using CPI.Models;
using System.Web.Http;
using System.Web.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CPI.ApiControllers
{
    [System.Web.Http.Route("api")]
    public class TwitterApi : BaseApiController
    {
        // GET api/values
        [System.Web.Http.Route("Twitter/{handle}"), System.Web.Http.HttpGet]
        public ContentResult Post(string handle)
        {
            ContentResult response = TwitterService.GetTweetsByUser(handle);

            string inputString = TwitterService.ParseResults(response.Content);

            ContentResult personality = PersonalityService.GetPersonality(inputString);

            return personality;
        }
    }
}
