using Abp.UI;
using BankApi.Interfaces;
using BankApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BankApi.Service
{
    public class BankService: IBankService
    {
        public BankService()
        {

        }

        public List_of_Banks GetListOfBanks()
        {
            var client = new HttpClient();
            var body = new RequestRespons();

            // Request headers

            client.DefaultRequestHeaders.CacheControl = CacheControlHeaderValue.Parse("no-cache");

            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "12518164f5624448aa7d430497a7f118");
            var uri = "https://wema-alatdev-apimgt.azure-api.net/alat-test/api/Shared/GetAllBanks";

            Task<HttpResponseMessage> request = client.GetAsync(uri);
            request.Wait();
            HttpResponseMessage response = request.Result;

            if (response.IsSuccessStatusCode)
            {
                Task<string> result = response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List_of_Banks>(result.Result);
            }
            else
            {
                Task<string> result = response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List_of_Banks>(result.Result);               
            }

        }

    }
}

