using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MobileAPIFelix.Model;

namespace MobileAPIFelix.Services
{
    public interface IRestService
    {
        Task<List<EntrieModel>> GetDataAsync();
    }
}
