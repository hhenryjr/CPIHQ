using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using SendGrid;
using System.Net.Mail;
using System.Threading.Tasks;
using Glimpse.AspNet.Tab;
using CPI.Models.Requests;

namespace CPI.Services
{
    public class MessagingService : BaseService
    {
        private static readonly string _siteAdminEmailAddress = ConfigurationManager.AppSettings["SiteAdminEmailAddress"];
        private static readonly string _sendGridUser = ConfigurationManager.AppSettings["SendGridUser"];
        private static readonly string _sendGridPass = ConfigurationManager.AppSettings["SendGridPass"];

        //public async Task Mail(MailRequest model)
        //{
        //    SendGridMessage myMessage = new SendGridMessage();

        //    myMessage.AddTo(_siteAdminEmailAddress);
        //    var user = UserService.GetCurrentUser();
        //    myMessage.From = new MailAddress(user.Email, user.UserName);
        //    myMessage.Subject = model.FormSubject;


        //    string path = HttpContext.Current.Server.MapPath("~/Template/ContactUs.html");
        //    string contents = File.ReadAllText(path);

        //    contents = contents.Replace("{{domain}}", "http://localhost:53700/");


        //    contents = contents.Replace("<%body%>", model.FormMessage);

        //    myMessage.Html = contents;


        //    await SendAsync(myMessage);

        //}

      
        public static async Task SendConfirmationEmail(SendConfirmationEmailRequest model) //****guide
        {
            var BaseURL = HttpContext.Current.Request.Url.Authority.ToString();
            SendGridMessage myMessage = new SendGridMessage();

            myMessage.AddTo(model.Email);
            myMessage.From = new MailAddress(_siteAdminEmailAddress, "CPI Team");
            myMessage.Subject = "Please Confirm Email";

            string path = HttpContext.Current.Server.MapPath("~/Template/ConfirmEmail.html");
            string contents = File.ReadAllText(path);

            contents = contents.Replace("{{domain}}", "http://" + BaseURL + "/confirm/" + model.Token);
            contents = contents.Replace("<%body%>", "Please Confirm Email");

            myMessage.Html = contents;

            await SendAsync(myMessage);

        }

        //****ADDED**** 
        public static async Task SendForgotPasswordEmail(SendConfirmationEmailRequest model)
        {
            var BaseURL = HttpContext.Current.Request.Url.Authority.ToString();
            SendGridMessage userEmailMessage = new SendGridMessage();

            userEmailMessage.AddTo(model.Email); //supplies the email into tokenMessage, so tokenMessage can be sent to the user
            userEmailMessage.From = new MailAddress(_siteAdminEmailAddress, "CPI Team");   //supplies from where it been sent into message
            userEmailMessage.Subject = "Please confirm reset password";                     //supplies subject into message

            string path = HttpContext.Current.Server.MapPath("~/Template/ForgotPasswordConfirmEmail.html"); //goes finds the ForgotPasswordConfirmEmail template
            string contents = File.ReadAllText(path); //reads it 

            contents = contents.Replace("{{domain}}", "http://" + BaseURL + "/ResetPassword/" + model.Token);
            contents = contents.Replace("<%body%>", "Please confirm reset password");

            userEmailMessage.Html = contents;

            await SendAsync(userEmailMessage); //syncs userEmailMessage
        }

        private static async Task SendAsync(ISendGrid message)
        {
            var credentials = new NetworkCredential(_sendGridUser, _sendGridPass);

            var trasportToWeb = new SendGrid.Web(credentials);

            await trasportToWeb.DeliverAsync(message);

        }

    }


}