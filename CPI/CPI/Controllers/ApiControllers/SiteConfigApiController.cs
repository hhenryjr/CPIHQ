﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http;
using CPI.Classes;

namespace CPI.Controllers.ApiControllers
{
    [RoutePrefix("api/siteconfig")]
    public class SiteConfigApiController
    {
        //private ISiteConfig _siteConfig;

        //public SiteConfigApiController(ISiteConfig config)
        //{
        //    _siteConfig = config;
        //}

        //[Route("config"), HttpGet]
        //public HttpResponseMessage Getconfig()
        //{
        //    return Request.CreateResponse(_siteConfig);
        //}

        //// Site Domain
        //[Route("SiteDomain"), HttpGet]
        //public string GetSiteDomain()
        //{
        //    string key = _siteConfig.SiteDomain;
        //    return key;
        //}

        //// Base URL
        //[Route("BaseUrl"), HttpGet]
        //public string GetMailChimpApiKey()
        //{
        //    string key = _siteConfig.BaseURL;
        //    return key;
        //}

        //// Google API Key
        //[Route("Google"), HttpGet]
        //public string GetGoogleApiKey()
        //{
        //    string key = _siteConfig.GoogleApiKey;
        //    return key;
        //}

       // Site Admin Email Address
       [Route("SiteAdminEmail"), HttpGet]
        public static string GetSiteAdminEmailAddress()
        {
            string key = SiteConfig.SiteAdminEmailAddress;
            return key;
        }

       [Route("SendGridUser"), HttpGet]
       public static string GetSendGridUser() {
           string key = SiteConfig.SendGridUser;
           return key;
       }

       [Route("SendGridPass"), HttpGet]
       public static string GetSendGridPass() {
           string key = SiteConfig.SendGridPass;
           return key;
       }

       [Route("PersonalityUser"), HttpGet]
       public static string GetPersonalityUser() {
           string key = SiteConfig.PersonalityUser;
           return key;
       }

       [Route("PersonalityPass"), HttpGet]
       public static string GetPersonalityPass() {
           string key = SiteConfig.PersonalityPass;
           return key;
       }


    }
}