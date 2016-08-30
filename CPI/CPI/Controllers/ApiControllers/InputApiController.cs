using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using CPI.Services;
using System.Web.Http;
using System.Web.Mvc;
using CPI.Models.Requests;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CPI.ApiControllers
{
    [System.Web.Http.RoutePrefix("api/Input")]
    public class InputApiController : BaseApiController
    {
        // GET api/values
        [System.Web.Http.Route(""), System.Web.Http.HttpPost]
        public ContentResult Post(AddTextRequest model)
        {
            //string baseUrl = "https://www.kimonolabs.com/api/";

            //ContentResult response = InputService.GetInput(baseUrl + url);

            //string inputString = InputService.ParseContent(response.Content);

            ContentResult personality = PersonalityService.GetPersonality(model.Text);

            return personality;
        }
    }
}
