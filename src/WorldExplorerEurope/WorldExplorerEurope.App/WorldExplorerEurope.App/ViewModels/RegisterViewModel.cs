using Newtonsoft.Json;
using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.Domain.Services.API;
using WorldExplorerEurope.App.ViewModels.Syncfusion;
using Xamarin.Forms;

namespace WorldExplorerEurope.App.ViewModels
{
    public class RegisterViewModel
    {
        private readonly SfDataForm _dataForm;
        public RegisterViewModel(SfDataForm dataForm)
        {
            this.user = new UserRegister();
            this._dataForm = dataForm;
        }
        private UserRegister user;
        public UserRegister newUser
        {
            get { return user; }
            set { this.user = value; }
        }

        public ICommand RegisterCommand => new Command(async ()
            =>
        {
            User createdUser = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = newUser.FirstName,
                LastName = newUser.LastName,
                Email = newUser.Email,
                BirthDate = newUser.BirthDate,
                Nationality = newUser.Nationality,
                IsAdmin = false
            };
            if (_dataForm.Validate() == true)
            {
                using (var httpClient = new HttpClient())
                {
                    string url = $"{WorldExplorerAPIService.BaseUrl}/users/register";
                    var rawJSON = JsonConvert.SerializeObject(newUser);
                    var content = new StringContent(rawJSON, Encoding.UTF8, "application/json");
                    HttpResponseMessage responseMessage = await httpClient.PostAsync(url, content);
                    var user = JsonConvert.DeserializeObject<User>(await responseMessage.Content.ReadAsStringAsync());
                    Debug.WriteLine($"{user.FirstName} {user.LastName} has logged in successfully");
                }
            }
        });
    }
}
