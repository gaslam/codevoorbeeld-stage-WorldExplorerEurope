using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WorldExplorerEurope.App.Domain.DTO;
using WorldExplorerEurope.App.Services.API;
using Xamarin.Forms;

namespace WorldExplorerEurope.App.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                RaisePropertyChanged(nameof(Email));
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                RaisePropertyChanged(nameof(Email));
            }
        }

        public ICommand Login => new Command(
            async () =>
            {
                UserLoginDto userLogin = new UserLoginDto
                {
                    Email = Email,
                    Password = Password
                };
                using(var httpClient = new HttpClient())
                {
                    string url = $"{WorldExplorerAPIService.baseUrl}/login";
                    var rawJSON = await Task.Run(() => JsonConvert.SerializeObject(userLogin))
                    var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");
                    HttpResponseMessage responseMessage = await httpClient.PostAsJsonAsync
            })

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
