using Insurance.Web.Mvc.Application.Contracts;
using Insurance.Web.Mvc.Models.PolicyViewModels;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Insurance.Web.Mvc.Application.Services.Masters
{
    public class PolicyCoverageTypeService : IPolicyCoverageTypeService
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpRequestMessagesHelper _httpRequestMessagesHelper;

        public PolicyCoverageTypeService(IConfiguration configuration, IHttpRequestMessagesHelper httpRequestMessagesHelper)
        {
            _configuration = configuration;
            _httpRequestMessagesHelper = httpRequestMessagesHelper;
        }

        public Task<bool> CreateAsync(PolicyCoverageTypeViewModel modelType)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync<TType>(TType id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditAsync(PolicyCoverageTypeViewModel modelType)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PolicyCoverageTypeViewModel>> GetAllAsync()
        {
            IEnumerable<PolicyCoverageTypeViewModel> result = default(List<PolicyCoverageTypeViewModel>);

            var request = _httpRequestMessagesHelper.CreateNonAuthorizedHttpRequestMessage($"{_configuration["ApiServer:Url"]}api/risktype", HttpMethod.Get);

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                    return result;

                var data = await response.Content.ReadAsStringAsync();

                try
                {
                    result = string.IsNullOrEmpty(data) ? default(List<PolicyCoverageTypeViewModel>) :
                            JsonConvert.DeserializeObject<List<PolicyCoverageTypeViewModel>>(data);
                }
                catch (Exception)
                {

                    return result;
                }
            }

            return result;
        }

        public Task<PolicyCoverageTypeViewModel> GetByIdAsync<TType>(TType id)
        {
            throw new NotImplementedException();
        }
    }
}
