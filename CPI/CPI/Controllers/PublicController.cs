using CPI.Models.ViewModels;
using CPI.Services;
using System;
using System.Web.Http;
using System.Web.Mvc;

namespace CPI.Controllers
{
    [System.Web.Http.AllowAnonymous]
    public class PublicController : BaseController
    {
        //public PublicController(ISiteConfig config) : base(config)
        //{ }

        // GET: Public
        [System.Web.Http.Route("~/Login")]
        [System.Web.Http.Route("~/")]
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

        [System.Web.Http.Route("~/Register")]
        public ActionResult Register()
        {
            return View();
        }
        
        [System.Web.Http.Route("~/Confirm/{token:guid}")]
        public ActionResult ConfirmEmail(Guid token)
        {
            ItemViewModel<Guid> model = new ItemViewModel<Guid>();
            model.Item = token;
            return View(model);
        }

        [System.Web.Http.Route("~/ForgotPassword")]
        public ActionResult ForgotPassword()
        {
            return View();
        }

        [System.Web.Http.Route("~/ResetPassword/{token:guid}")]
        public ActionResult ResetPassword(Guid token)
        {
            return View(token);
        }        
    }
}

