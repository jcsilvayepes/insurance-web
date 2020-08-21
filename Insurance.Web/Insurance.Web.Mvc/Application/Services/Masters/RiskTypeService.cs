using Insurance.Web.Mvc.Application.Contracts;
using Insurance.Web.Mvc.Models.RiskViewModels;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Insurance.Web.Mvc.Application.Services.Masters
{
    public class RiskTypeService : IRiskTypeService
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpRequestMessagesHelper _httpRequestMessagesHelper;

        public RiskTypeService(IConfiguration configuration, IHttpRequestMessagesHelper httpRequestMessagesHelper)
        {
            _configuration = configuration;
            _httpRequestMessagesHelper = httpRequestMessagesHelper;
        }

        public Task<bool> CreateAsync(RiskTypeViewModel modelType)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync<TType>(TType id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditAsync(RiskTypeViewModel modelType)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RiskTypeViewModel>> GetAllAsync()
        {
            
            IEnumerable<RiskTypeViewModel> result = default(List<RiskTypeViewModel>);

            var request = _httpRequestMessagesHelper.CreateNonAuthorizedHttpRequestMessage($"{_configuration["ApiServer:Url"]}api/risktype", HttpMethod.Get);

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                    return result;

                var data = await response.Content.ReadAsStringAsync();

                try
                {
                    result = string.IsNullOrEmpty(data) ? default(List<RiskTypeViewModel>) :
                            JsonConvert.DeserializeObject<List<RiskTypeViewModel>>(data);
                }
                catch (Exception)
                {

                    return result;
                }
            }

            return result;
        }

        public Task<RiskTypeViewModel> GetByIdAsync<TType>(TType id)
        {
            throw new NotImplementedException();
        }

    }
}
