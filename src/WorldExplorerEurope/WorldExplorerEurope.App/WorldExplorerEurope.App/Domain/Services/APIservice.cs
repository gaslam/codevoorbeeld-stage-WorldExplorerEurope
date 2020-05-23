using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WorldExplorerEurope.API.Services.Interface;
using WorldExplorerEurope.App.Domain.Models.Base;

namespace WorldExplorerEurope.App.Domain.Services
{
    public class APIservice : IAPIinterface
    {

        public static HttpClient Client;

        public void SetTestClient(HttpClient client)
        {
            Client = client;
        }
        public async Task<string> Get(string url)
        {
            try
            {
                using (var webClient = Client)
                {
                    if (Client.DefaultRequestHeaders.Authorization != null) Client.DefaultRequestHeaders.Authorization = null;
                    var download = webClient.GetStringAsync(url).Result;
                    return download.ToString();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<HttpResponseMessage> Post(string url, string json)
        {
            try
            {
                using (var httpClient = Client)
                {
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage responseMessage = await httpClient.PostAsync(url, content);
                    return responseMessage;
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<HttpResponseMessage> Delete(string url, string token)
        {
            try
            {
                using (var httpClient = Client)
                {
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    HttpResponseMessage responseMessage = await httpClient.DeleteAsync(url);
                    return responseMessage;
                }
            }
            catch
            {
                return null;
            }
        }
        public async Task<HttpResponseMessage> Put(string url, string json, string token)
        {
            try
            {
                using (var httpClient = Client)
                {
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage responseMessage = await httpClient.PutAsync(url, content);
                    return responseMessage;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
