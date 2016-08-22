﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dotnetCloudantWebstarter.Models.Responses
{
    /// <summary>
    /// This is an example of a Generic class that you will gain an understanding off
    /// as you progress through the training.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ItemResponse<T> : SucessResponse
    {

        public T Item { get; set; }

        public string Message { get; set; }

    }
}