﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CPI.Models.Requests
{
    public class ForgotPasswordRequest
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }

    }
}