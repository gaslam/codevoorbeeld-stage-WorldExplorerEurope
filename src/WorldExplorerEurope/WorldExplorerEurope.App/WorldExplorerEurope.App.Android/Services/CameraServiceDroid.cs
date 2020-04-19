using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Plugin.Media.Abstractions;
using WorldExplorerEurope.App.Domain.Services;

[assembly: Xamarin.Forms.Dependency(typeof(WorldExplorerEurope.App.Droid.Services.CameraServiceDroid))]
namespace WorldExplorerEurope.App.Droid.Services
{
    public class CameraServiceDroid : ICameraService
    {
        public async Task<bool> CheckAndroidCameraPermissions()
        {
            return false;
        }

        public async Task<MediaFile> TakePicture()
        {
            return null;
        }

        public async Task<MediaFile> PickPicture()
        {
            return null;
        }
    }
}