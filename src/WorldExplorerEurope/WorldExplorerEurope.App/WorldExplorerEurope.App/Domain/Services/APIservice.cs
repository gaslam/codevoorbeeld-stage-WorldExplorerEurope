using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WorldExplorerEurope.API.Services.Interface;
using WorldExplorerEurope.App.Domain.Models.Base;

namespace WorldExplorerEurope.App.Domain.Services
{
    public class APIservice : IAPIinterface
    {
        public async Task<string> Get(string url)
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    string download = webClient.DownloadString(url);
                    return download;
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<HttpResponseMessage> Post(string url, string json)
        {
            try
            {
                using (var httpClient = new HttpClient())
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

        public async Task<HttpResponseMessage> Delete(string url)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await httpClient.DeleteAsync(url);
                    return responseMessage;
                }
            }
            catch
            {
                return null;
            }
        }
        public async Task<HttpResponseMessage> Put(string url, string json)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage responseMessage = await httpClient.PutAsync(url, content);
                    return responseMessage;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
