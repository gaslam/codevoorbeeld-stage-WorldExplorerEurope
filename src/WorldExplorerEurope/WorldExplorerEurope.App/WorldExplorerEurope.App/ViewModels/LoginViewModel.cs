﻿using FreshMvvm;
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
using WorldExplorerEurope.API.Services.Interface;
using WorldExplorerEurope.App.Domain.DTO;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.Domain.Services;
using WorldExplorerEurope.App.Domain.Services.API;
using WorldExplorerEurope.ViewModels.Syncfusion;
using WorldExplorerEurope.App.Pages;
using Xamarin.Forms;
using WorldExplorerEurope.App.ViewModels;
using WorldExplorerEurope.ViewModels;
using WorldExplorerEurope.App.Views;

namespace WorldExplorerEurope.App.ViewModels
{
    public class LoginViewModel : FreshBasePageModel, INotifyPropertyChanged
    {

        private IAPIinterface _apiService;

        public event PropertyChangedEventHandler PropertyChanged;

        public LoginViewModel(IAPIinterface apiService)
        {
            _apiService = apiService;
        }

        public async override void Init(object initData)
        {
            base.Init(initData);
            this.newUser = new UserLogin();
            DataForm = new SfDataForm();
            DataForm.DataObject = newUser;
            ActivityIndicator = false;
        }

        public override void ReverseInit(object initData)
        {
            base.Init(initData);
        }

        public SfDataForm DataForm;

        private UserLogin user;
        public UserLogin newUser
        {
            get { return user; }
            set
            {
                this.user = value;
                ChangeProperty(nameof(newUser));
            }
        }

        private void ChangeProperty(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private bool activityIndicator;
        public bool ActivityIndicator
        {
            get { return activityIndicator; }
            set
            {
                this.activityIndicator = value;
                ChangeProperty(nameof(ActivityIndicator));
            }
        }

        //only for tests
        public bool test = false;

        public ICommand LoginCommand => new Command(

            async () =>
            {
                ActivityIndicator = true;
                bool isValid = DataForm.Validate();
                if (isValid == true)
                {
                    UserLoginDto userLogin = new UserLoginDto
                    {
                        Email = newUser.Email,
                        Password = newUser.Password
                    };
                    var request = await _apiService.Post($"{WorldExplorerAPIService.BaseUrl}/users/login", JsonConvert.SerializeObject(userLogin));
                    //if (request == null) await App.Current.MainPage.DisplayAlert("Service not reachable!!", "Cannot connect to WorldExplorerService.\n\nCheck your wifi settings or try later to connect!!", "OK");
                    if (!request.IsSuccessStatusCode)
                    {
                        newUser.ErrorMessage = await request.Content.ReadAsStringAsync();
                        ActivityIndicator = false;
                    }
                    else if(!test)
                    {
                        var user = JsonConvert.DeserializeObject<User>(await request.Content.ReadAsStringAsync());
                        UserService userService = new UserService();
                        userService.SetUser(user);
                        App.Current.MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<MyCountriesViewModel>())
                        {
                            BarBackgroundColor = Color.FromHex(ToolBarBackgroundcolor.backgroundColor)
                        };

                        ActivityIndicator = false;
                    }
                }
            });

        public ICommand RegisterCommand => new Command(
            async () =>
                {
                    await CoreMethods.PushPageModel<RegisterViewModel>(true);

                }
            );
    }
}
