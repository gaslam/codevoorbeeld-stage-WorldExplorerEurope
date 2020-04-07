using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WorldExplorerEurope.App.ViewModels.Syncfusion
{
    public class UserLogin : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string email;

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

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

        [Display(AutoGenerateField = false)]
        public bool HasErrors
        {
            get { return false; }
        }

        private string errorMessage;
        [Display(AutoGenerateField = false)]
        public string ErrorMessage
        {
            get { return errorMessage; }
            set
            {
                this.errorMessage = value;
                RaisePropertyChanged(nameof(ErrorMessage));
            }
        }

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public IEnumerable GetErrors(string propertyName)
        {
            var list = new List<string>();

            var validEmail = new EmailAddressAttribute();

            if (propertyName.Equals("Email"))
            {
                if (!validEmail.IsValid(Email) || string.IsNullOrEmpty(Email))
                    list.Add("Please, enter a valid email");
            }

            if (propertyName.Equals("Password"))
            {
                if (string.IsNullOrEmpty(Password))
                    list.Add("Please, enter a password");
            }

            return list;
        }

    }
}
