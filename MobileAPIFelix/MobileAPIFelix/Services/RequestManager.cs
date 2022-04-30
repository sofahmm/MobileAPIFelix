using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using MobileAPIFelix.Model;

namespace MobileAPIFelix.Services
{
    public class RequestManager
    {
        IRestService restService;
        public RequestManager(IRestService service)
        {
            restService = service;
        }
        public Task<ObservableCollection<EntrieModel>> GetEntrieModels()
        {
            return restService.GetDataAsync();
        }
    }
}
