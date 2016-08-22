using dotnetCloudantWebstarter.Models.ViewModels;
using dotnetCloudantWebstarter.Services;
using System;
using Microsoft.AspNet.Mvc;

namespace dotnetCloudantWebstarter.Controllers
{
    [AllowAnonymous]
    public class PublicController : BaseController
    {
        //public PublicController(ISiteConfig config) : base(config)
        //{ }

        // GET: Public
        [Route("~/Login")]
        [Route("~/")]
        public ActionResult Login()
        {
            return View();
        }

        //[Route("~/Logout")]
        //public ActionResult Logout()
        //{
        //    UserService.Logout();
        //    return RedirectToAction("Index", "Home");
        //}

        [Route("~/Register")]
        public ActionResult Register()
        {
            return View();
        }
        
        [Route("~/Confirm/{token:guid}")]
        public ActionResult ConfirmEmail(Guid token)
        {
            ItemViewModel<Guid> model = new ItemViewModel<Guid>();
            model.Item = token;
            return View(model);
        }

        [Route("~/ForgotPassword")]
        public ActionResult ForgotPassword()
        {
            return View();
        }

        [Route("~/ResetPassword/{token:guid}")]
        public ActionResult ResetPassword(Guid token)
        {
            return View(token);
        }        
    }
}

