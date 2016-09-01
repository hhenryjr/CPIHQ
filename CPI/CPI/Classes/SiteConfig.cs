using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace CPI.Classes
{
    /// <summary>
    /// Encapsulates keys and other settings from the web.config file
    /// </summary>
    public class SiteConfig
    {

        //public string BrandDescription
        //{
        //    get { return GetFromConfig("BrandDescription"); }
        //}

        //public string BrandName
        //{
        //    get { return GetFromConfig("BrandName"); }
        //}

        //public string BrandTagline
        //{
        //    get { return GetFromConfig("BrandTagline"); }
        //}

        //public string BrandLogo
        //{
        //    get { return GetFromConfig("BrandLogo"); }
        //}

        //public string SiteDomain
        //{
        //    get { return GetFromConfig("SiteDomain"); }
        //}

        //public string BaseURL
        //{
        //    get { return GetFromConfig("BaseURL"); }
        //}

        public static string SiteAdminEmailAddress
        {
            get { return GetFromConfig("SiteAdminEmailAddress"); }
        }

        //public string AwsAccessKey
        //{
        //    get { return GetFromConfig("AWSAccessKey"); }
        //}

        //public string AwsSecretAccessKey
        //{
        //    get { return GetFromConfig("AWSSecretKey"); }
        //}

        //public string GoogleApiKey
        //{
        //    get { return GetFromConfig("GoogleApiKey"); }
        //}

        #region private methods

        private static string GetFromConfig(string key)
        {
            return WebConfigurationManager.AppSettings[key];
        }

        #endregion
    }
}
