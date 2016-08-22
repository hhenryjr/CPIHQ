using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CPI.Services;
using System.Web.Http;
using System.Web.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CPI.ApiControllers
{
    [System.Web.Http.RoutePrefix("api")]
    public class PersonalityApiController : BaseApiController
    {        
        // POST api/values
        [System.Web.Http.Route("Personality"), System.Web.Http.HttpPost]
        public ContentResult Post()
        {
            ContentResult response = PersonalityService.GetPersonality();
            return response;
        }
        
    }
}
