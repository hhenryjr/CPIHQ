using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Mvc;
using System.ComponentModel.DataAnnotations;

namespace dotnetCloudantWebstarter.Models.Requests.ForgotPassword
{
    public class ForgotPasswordRequest
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }

    }
}