using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldExplorerEurope.API.Services.Interface
{
    public interface IAPIinterface<Dto>
    {
        Task<string> Get(string url);
        Task<string> Post(string url);
        Task<string> Put(string url);
        Task<string> Delete(string url);
    }
}
