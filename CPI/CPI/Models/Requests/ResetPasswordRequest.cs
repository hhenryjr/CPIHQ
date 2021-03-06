﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using CPI.Models.Requests;

namespace CPI.Models.Requests
{
    public class ResetPasswordRequest 
    {
        [Required]
        public string NewPassword { get; set; } //applying this as an addition to ForgotPasswordRequest

        [Required]
        public string TokenId { get; set; }
    }
}