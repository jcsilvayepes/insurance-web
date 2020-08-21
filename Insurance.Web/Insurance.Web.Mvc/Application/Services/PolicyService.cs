using Insurance.Web.Mvc.Application.Contracts;
using Insurance.Web.Mvc.Models.PolicyViewModels;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Web.Mvc.Application.Services
{
    public class PolicyService : IPolicyService
    {

        private readonly IConfiguration _configuration;
        private readonly IHttpRequestMessagesHelper _httpRequestMessagesHelper;

        public PolicyService(IConfiguration configuration, IHttpRequestMessagesHelper httpRequestMessagesHelper)
        {
            _configuration = configuration;
            _httpRequestMessagesHelper = httpRequestMessagesHelper;
        }

        public async Task<bool> CreateAsync(PolicyViewModel modelType)
        {
            PolicyViewModel policyModel = new PolicyViewModel();

            var content = new StringContent(JsonConvert.SerializeObject(modelType), Encoding.UTF8, "application/json");

            var request = _httpRequestMessagesHelper.CreateNonAuthorizedHttpRequestMessage($"{_configuration["ApiServer:Url"]}api/policy", HttpMethod.Post, content);

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.SendAsync(request);

                if (response.IsSuccessStatusCode)
                    return true;

                return false;
            }
        }

        public Task<bool> DeleteAsync<TType>(TType id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditAsync(PolicyViewModel modelType)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PolicyViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PolicyViewModel> GetByIdAsync<TType>(TType id)
        {
            throw new NotImplementedException();
        }
    }
}
