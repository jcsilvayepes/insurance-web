using Insurance.Web.Mvc.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Insurance.Web.Mvc.Application.Helpers
{
    public class HttpRequestMessagesHelper : IHttpRequestMessagesHelper
    {
        public HttpRequestMessage CreateNonAuthorizedHttpRequestMessage(string requestUri, HttpMethod method)
        {
            return new HttpRequestMessage()
            {
                RequestUri = new Uri(requestUri),
                Method = method
            };
        }

        public HttpRequestMessage CreateNonAuthorizedHttpRequestMessage(string requestUri, HttpMethod method, HttpContent content)
        {
            return new HttpRequestMessage()
            {
                RequestUri = new Uri(requestUri),
                Method = method,
                Content = content
            };
        }
    }
}
