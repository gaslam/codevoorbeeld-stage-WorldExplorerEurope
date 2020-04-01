using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WorldExplorerEurope.App.ViewModels.Syncfusion
{
    public class UserLogin : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string email;

        [JsonProperty(PropertyName = "email")]
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

        [JsonProperty(PropertyName = "email")]
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                RaisePropertyChanged(nameof(Email));
            }
        }
        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

    }
}
