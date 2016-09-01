using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CPI.Models.Requests
{
    public class AddTextRequest
    {
        [Required]
        public string Text { get; set; }
    }
}