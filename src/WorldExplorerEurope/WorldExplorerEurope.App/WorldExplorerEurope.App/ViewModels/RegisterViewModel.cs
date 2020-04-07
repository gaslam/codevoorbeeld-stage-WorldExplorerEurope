using Newtonsoft.Json;
using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.Domain.Services;
using WorldExplorerEurope.App.Domain.Services.API;
using WorldExplorerEurope.App.ViewModels.Syncfusion;
using Xamarin.Forms;

namespace WorldExplorerEurope.App.ViewModels
{
    public class RegisterViewModel : APIservice
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
                Password = newUser.Password,
                IsAdmin = false
            };
            if (_dataForm.Validate() == true)
            {
                var request = await Post($"{WorldExplorerAPIService.BaseUrl}/users/register", JsonConvert.SerializeObject(createdUser));
                if (request == null) await App.Current.MainPage.DisplayAlert("Service not reachable!!", "Cannot connect to WorldExplorerService.\n\nCheck your wifi settings or try later to connect!!", "OK");
                else if (!request.IsSuccessStatusCode) newUser.ErrorMessage = await request.Content.ReadAsStringAsync();
                else
                {
                    Debug.WriteLine("connection successfull!!");
                }
            }
        });
    }
}
