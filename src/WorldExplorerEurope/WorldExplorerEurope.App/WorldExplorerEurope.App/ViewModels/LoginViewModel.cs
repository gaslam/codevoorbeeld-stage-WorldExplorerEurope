using Newtonsoft.Json;
using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WorldExplorerEurope.App.Domain.DTO;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.Domain.Services.API;
using WorldExplorerEurope.App.ViewModels.Syncfusion;
using WorldExplorerEurope.App.Views;
using Xamarin.Forms;

namespace WorldExplorerEurope.App.ViewModels
{
    public class LoginViewModel
    {
        private INavigation Navigation;

        public LoginViewModel(INavigation PageNav)
        {
            Navigation = PageNav;
            this.user = new UserLogin();
        }
        public SfDataForm DataForm;

        private UserLogin user;
        public UserLogin newUser
        {
            get { return user; }
            set { this.user = value; }
        }

        public ICommand LoginCommand => new Command(
            async () =>
            {
                bool isValid = DataForm.Validate();
                if(isValid == true)
                {
                    UserLoginDto userLogin = new UserLoginDto
                    {
                        Email = newUser.Email,
                        Password = newUser.Password
                    };
                    using (var httpClient = new HttpClient())
                    {
                        string url = $"{WorldExplorerAPIService.BaseUrl}/users/login";
                        var rawJSON = JsonConvert.SerializeObject(userLogin);
                        var content = new StringContent(rawJSON, Encoding.UTF8, "application/json");
                        HttpResponseMessage responseMessage = await httpClient.PostAsync(url, content);
                        var user = JsonConvert.DeserializeObject<User>(await responseMessage.Content.ReadAsStringAsync());
                        Debug.WriteLine($"{user.FirstName} {user.LastName} has logged in successfully");
                    }
                }
            });

        public ICommand RegisterCommand => new Command(
            async () =>
                {
                    await Navigation.PushModalAsync(new RegisterPage(), true);
                }
            );
    }
}
