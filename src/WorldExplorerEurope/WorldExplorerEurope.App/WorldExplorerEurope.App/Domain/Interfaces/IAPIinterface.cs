using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WorldExplorerEurope.API.Services.Interface
{
    public interface IAPIinterface
    {
        Task<string> Get(string url);
        Task<HttpResponseMessage> Post(string url, string json);
        Task<HttpResponseMessage> Put(string url, string json);
        Task<HttpResponseMessage> Delete(string url);
    }
}
