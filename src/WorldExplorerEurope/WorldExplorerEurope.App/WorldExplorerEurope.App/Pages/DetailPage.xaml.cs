using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldExplorerEurope.App.Domain.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorldExplorerEurope.App.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(User user)
        {
            InitializeComponent();
        }
    }
}