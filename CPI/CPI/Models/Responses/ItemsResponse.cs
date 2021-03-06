﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPI.Models.Responses
{
    /// <summary>
    /// This is an example of a Generic class that you will gain an understanding off
    /// as you progress through the training.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ItemsResponse<T> : SucessResponse
    {
        public List<T> Items { get; set; }
    }
}