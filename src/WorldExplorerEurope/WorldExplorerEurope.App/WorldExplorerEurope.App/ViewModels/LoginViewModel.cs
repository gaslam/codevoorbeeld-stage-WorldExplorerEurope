using Newtonsoft.Json;
using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WorldExplorerEurope.App.Domain.DTO;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.Domain.Services.API;
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


        public ICommand Login => new Command(
            async () =>
            {
                UserLoginDto userLogin = new UserLoginDto
                {
                    Email = "",
                    Password = ""
                };
                /*using (var httpClient = new HttpClient())
                {
                    string url = $"{WorldExplorerAPIService.BaseUrl}/login";
                    var rawJSON = await Task.Run(() => JsonConvert.SerializeObject(userLogin));
                    var httpContent = new StringContent(rawJSON, Encoding.UTF8, "application/json");
                    HttpResponseMessage responseMessage = await httpClient.PostAsync(url, httpContent);
                }*/
                Console.WriteLine("test");
            });
        public ICommand RegisterCommand => new Command(
            async () =>
                {
                    Console.WriteLine("test");
                }
            );

        private void DataForm_AutoGeneratingDataFormItem(object sender, AutoGeneratingDataFormItemEventArgs e)
        {
            var name = e.DataFormItem.Name;
            switch (name)
            {
                case "Email":
                    e.DataFormItem = new DataFormTextItem() { Name = "Email", Editor = "Text", PlaceHolderText = "Enter Email", KeyBoard = Keyboard.Email };
                    break;
                case "Password":
                    e.DataFormItem = new DataFormTextItem() { Name = "Password", Editor = "Password", PlaceHolderText = "Enter Password", KeyBoard = Keyboard.Text };
                    break;
            }
        }
    }
}
