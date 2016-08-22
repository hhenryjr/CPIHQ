using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using dotnetCloudantWebstarter.Services;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace dotnetCloudantWebstarter.Controllers
{
    [Route("api")]
    public class PersonalityApiController : Controller
    {
        
        // POST api/values
        [Route("Personality"),HttpPost]
        public ContentResult Post()
        {
            ContentResult response = PersonalityService.GetPersonality();
            return response;
        }
        
    }
}
