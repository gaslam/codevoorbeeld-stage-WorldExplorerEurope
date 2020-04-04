using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.App.ViewModels.Syncfusion;

namespace WorldExplorerEurope.App.ViewModels
{
    public class RegisterViewModel
    {
        public RegisterViewModel()
        {
            this.user = new UserRegister();
        }
        private UserRegister user;
        public UserRegister newUser
        {
            get { return user; }
            set { this.user = value; }
        }
    }
}
