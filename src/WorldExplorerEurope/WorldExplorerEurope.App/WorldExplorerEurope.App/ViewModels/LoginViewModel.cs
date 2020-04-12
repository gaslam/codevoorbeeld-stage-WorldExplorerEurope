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
using WorldExplorerEurope.App.Domain.Services;
using WorldExplorerEurope.App.Domain.Services.API;
using WorldExplorerEurope.App.ViewModels.Syncfusion;
using WorldExplorerEurope.App.Views;
using Xamarin.Forms;

namespace WorldExplorerEurope.App.ViewModels
{
    public class LoginViewModel : APIservice, FreshBaseModel
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
                    var request = await Post($"{WorldExplorerAPIService.BaseUrl}/users/login", JsonConvert.SerializeObject(userLogin));
                    if (request == null) await App.Current.MainPage.DisplayAlert("Service not reachable!!", "Cannot connect to WorldExplorerService.\n\nCheck your wifi settings or try later to connect!!", "OK");
                    else if (!request.IsSuccessStatusCode) newUser.ErrorMessage = await request.Content.ReadAsStringAsync();
                    else
                    {
                        var user = JsonConvert.DeserializeObject<User>(await request.Content.ReadAsStringAsync());
                        UserService userService = new UserService();
                        userService.SetUser(user);
                    }
                }
            });

        public ICommand RegisterCommand => new Command(
            async () =>
                {
                    await Navigation.PushModalAsync(new RegisterPage(Navigation), true);
                }
            );
    }
}
