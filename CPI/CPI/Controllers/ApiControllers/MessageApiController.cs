
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CPI.Models.Requests;
using CPI.Models.Responses;
using CPI.Services;

namespace CPI.ApiControllers

    // API Controller is Required for An endpoint to Ajax Call 
    // Endpoint is a method in Api Controller 
{
    [AllowAnonymous]
    [RoutePrefix("api/message")]
    public class MessageApiController : BaseApiController 
    {
        //[Route("ContactUs"), HttpPost]
        //public async System.Threading.Tasks.Task<HttpResponseMessage> SendMail(MailRequest model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        //    }

        //    SucessResponse response = new SucessResponse();

        //    await MessagingService.Mail(model);

        //    return Request.CreateResponse(response);

        //}

        //[Route("ConfirmEmail"), HttpPost]
        //public async System.Threading.Tasks.Task<HttpResponseMessage> SendConfirmMail(SendConfirmationEmailRequest model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        //    }

        //    SucessResponse response = new SucessResponse();

        //    await MessagingService.SendConfirmationEmail(model);

        //    return Request.CreateResponse(response);

        //}

        //[Route("ForgotPass"), HttpPost]
        //public async System.Threading.Tasks.Task<HttpResponseMessage> SendForgotPasswordEmail(SendConfirmationEmailRequest model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        //    }

        //    SucessResponse response = new SucessResponse();

        //    await MessagingService.SendConfirmationEmail(model);

        //    return Request.CreateResponse(response);

        //}

    }
}
