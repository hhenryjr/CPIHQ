﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPI.Models.Responses
{
    /// <summary>
    /// This class simply sets IsSuccesFull to true by default.
    /// Many of the response classes will end up inhering from here
    /// since they would be returning IsSuccessFull = true
    /// </summary>
    public class SucessResponse :  BaseResponse
    {
        public SucessResponse()
        {
            
            this.IsSuccessFull = true;
        }
    }
}