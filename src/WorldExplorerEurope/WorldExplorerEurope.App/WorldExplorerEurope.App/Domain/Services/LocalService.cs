using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using WorldExplorerEurope.API.Services.Interface;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.Domain.Services.API;
using WorldExplorerEurope.Domain.Models;
using Xamarin.Forms;

namespace WorldExplorerEurope.App.Domain.Services
{
    public class LocalService : APIservice
    {
        private static ObservableCollection<Country> Countries;

        public void SetUser(User newUser)
        {
            Application.Current.Properties["User"] = newUser;
        }

        public User GetUser()
        {
            if (Application.Current.Properties.ContainsKey("user"))
            {
                return Application.Current.Properties["User"] as User;
            }
            return null;
        }

        public async Task<ObservableCollection<Country>> GetCountriesAsync()
        {
            if (Countries == null || Countries.Count == 0)
            {
                Countries = new ObservableCollection<Country>();
                string responseMessage = await Get($"{WorldExplorerAPIService.BaseUrl}");
                Countries = JsonConvert.DeserializeObject<ObservableCollection<Country>>(responseMessage);
            }
            return Countries;  

        }
    }
}
