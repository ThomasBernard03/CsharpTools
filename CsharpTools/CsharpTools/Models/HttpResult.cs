﻿using System.Net;

namespace CsharpTools.Models
{
    public class HttpResult<T>
    {
        public string ErrorMessage { get; set; }
        public T Content { get; set; }
        public HttpStatusCode Status { get; set; }
        public HttpRequestMessage RequestMessage { get; set; }

        public HttpResult()
        {

        }

        public HttpResult(HttpResponseMessage httpResponseMessage)
        {
            RequestMessage = httpResponseMessage.RequestMessage;
            Status = httpResponseMessage.StatusCode;
        }
    }
}
