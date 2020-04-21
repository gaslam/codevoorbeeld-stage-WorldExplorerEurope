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

        public void RemoveUser()
        {
            Application.Current.Properties["User"] = null;
        }

        public User GetUser()
        {
            if (Application.Current.Properties.ContainsKey("User") && Application.Current.Properties["User"] != null)
            {
                return Application.Current.Properties["User"] as User;
            }
            return null;
        }

        public async Task<ObservableCollection<Country>> GetCountriesAsync()
        {
                Countries = new ObservableCollection<Country>();
                string responseMessage = await Get($"{WorldExplorerAPIService.BaseUrl}");
                Countries = JsonConvert.DeserializeObject<ObservableCollection<Country>>(responseMessage);
            return Countries;  

        }
    }
}
