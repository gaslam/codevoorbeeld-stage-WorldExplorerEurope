﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WorldExplorerEurope.VUE.services
{
    public class ApiService
    {
        public async Task<string> Get(string url)
        {
            try
            {
                using (var webClient = new HttpClient())
                {
                    var response = await webClient.GetAsync(url);
                    string download = await response.Content.ReadAsStringAsync();
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
