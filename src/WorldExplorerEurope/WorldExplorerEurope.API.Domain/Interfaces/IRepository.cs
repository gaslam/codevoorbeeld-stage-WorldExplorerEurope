using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Domain.Interfaces
{
    public interface IRepository<T> where T : EntityBase
    {
    }
}
