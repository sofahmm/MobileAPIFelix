using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using MobileAPIFelix.Model;

namespace MobileAPIFelix.Services
{
    public interface IRestService
    {
        Task<ObservableCollection<EntrieModel>> GetDataAsync();
    }
}
