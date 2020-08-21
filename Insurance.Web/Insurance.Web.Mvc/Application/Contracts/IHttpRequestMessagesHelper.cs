using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Insurance.Web.Mvc.Application.Contracts
{
    public interface IHttpRequestMessagesHelper
    {
        HttpRequestMessage CreateNonAuthorizedHttpRequestMessage(string requestUri, HttpMethod method);

        HttpRequestMessage CreateNonAuthorizedHttpRequestMessage(string requestUri, HttpMethod method, HttpContent content);
    }
}
