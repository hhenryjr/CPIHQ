using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

using System.Net;
using dotnetCloudantWebstarter.Services;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace dotnetCloudantWebstarter.Controllers
{
    [Route("api")]
    public class InputApiController : Controller
    {
        // GET api/values
        [Route("Input/{url}"), HttpGet]
        public ContentResult Post(string url)
        {
            string baseUrl = "https://www.kimonolabs.com/api/";

            ContentResult response = InputService.GetInput(baseUrl+url);

            string inputString = InputService.ParseContent(response.Content);

            ContentResult personality = PersonalityService.GetPersonality(inputString);

            return personality;
        }
    }
}
