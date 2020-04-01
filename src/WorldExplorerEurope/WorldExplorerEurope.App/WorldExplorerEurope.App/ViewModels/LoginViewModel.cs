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
using Xamarin.Forms;

namespace WorldExplorerEurope.App.ViewModels
{
    public class LoginViewModel
    {

        public LoginViewModel()
        {
            this.user = new UserLogin();
        }

        private UserLogin user;
        public UserLogin newUser
        {
            get { return user; }
            set { this.user = value; }
        }


        public ICommand LoginCommand => new Command(
            async () =>
            {
                UserLoginDto userLogin = new UserLoginDto
                {
                    Email = newUser.Email,
                    Password = newUser.Password
                };
                using (var httpClient = new HttpClient())
                {
                    string url = $"http://192.168.0.181:5000/api/countries/users/login";
                    var rawJSON = JsonConvert.SerializeObject(userLogin);
                    var content = new StringContent(rawJSON, Encoding.UTF8, "application/json");
                    HttpResponseMessage responseMessage = await httpClient.PostAsync(url, content);
                    var user = JsonConvert.DeserializeObject<User>(await responseMessage.Content.ReadAsStringAsync());
                    Debug.WriteLine($"{user.FirstName} {user.LastName} has logged in successfully");
                }
            });
        public ICommand RegisterCommand => new Command(
            async () =>
                {

                }
            );

        private void DataForm_AutoGeneratingDataFormItem(object sender, AutoGeneratingDataFormItemEventArgs e)
        {
            var name = e.DataFormItem.Name;
            switch (name)
            {
                case "Email":
                    e.DataFormItem = new DataFormTextItem() { Name = "Email", Editor = "Text", PlaceHolderText = "Enter Email", KeyBoard = Keyboard.Email };
                    e.DataFormItem.HintLabelStyle = new LabelStyle { FontFamily = Device.OnPlatform("ROBOTOMONO-REGULAR", "ROBOTOMONO-REGULAR.TTF#ROBOTOMONO-REGULAR", "Assets/Fonts/ROBOTOMONO-REGULAR.TTF#ROBOTOMONO"), FontSize = 16 };
                    e.DataFormItem.HelperLabelStyle = new LabelStyle { FontFamily = Device.OnPlatform("ROBOTOMONO-REGULAR", "ROBOTOMONO-REGULAR.TTF#ROBOTOMONO-REGULAR", "Assets/Fonts/ROBOTOMONO-REGULAR.TTF#ROBOTOMONO")};
                    break;
                case "Password":
                    e.DataFormItem = new DataFormTextItem() { Name = "Password", Editor = "Password", PlaceHolderText = "Enter Password", KeyBoard = Keyboard.Text };
                    e.DataFormItem.HintLabelStyle = new LabelStyle { FontFamily = Device.OnPlatform("ROBOTOMONO-REGULAR", "ROBOTOMONO-REGULAR.TTF#ROBOTOMONO-REGULAR", "Assets/Fonts/ROBOTOMONO-REGULAR.TTF#ROBOTOMONO"), FontSize = 16 };
                    e.DataFormItem.HelperLabelStyle = new LabelStyle { FontFamily = Device.OnPlatform("ROBOTOMONO-REGULAR", "ROBOTOMONO-REGULAR.TTF#ROBOTOMONO-REGULAR", "Assets/Fonts/ROBOTOMONO-REGULAR.TTF#ROBOTOMONO") };
                    break;
            }
        }
    }
}
