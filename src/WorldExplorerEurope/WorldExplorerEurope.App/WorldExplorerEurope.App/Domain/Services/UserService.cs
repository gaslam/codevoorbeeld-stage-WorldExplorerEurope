using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.App.Domain.Models;
using Xamarin.Forms;

namespace WorldExplorerEurope.App.Domain.Services
{
    public class UserService
    {

        private void SetUser(User newUser)
        {
            Application.Current.Properties["User"] = newUser;
        }

        private User GetUser()
        {
            if (Application.Current.Properties.ContainsKey("user"))
            {
                return Application.Current.Properties["User"] as User;
            }
            return null;
        }
    }
}
