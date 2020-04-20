using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldExplorerEurope.App.Domain.Services;

[assembly: Xamarin.Forms.Dependency(typeof(WorldExplorerEurope.App.UWP.Services.CameraServiceUwp))]
namespace WorldExplorerEurope.App.UWP.Services
{
    public class CameraServiceUwp : ICameraService
    {
        public async Task<bool> CheckAndroidCameraPermissions()
        {
            //Windows already asks for permission so there is no need for this.
            return true;
        }

        public async Task<MediaFile> TakePicture()
        {
            try
            {
                if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                {
                    return null;
                }
                else
                {
                    var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                    {
                        Directory="test",
                        SaveToAlbum = true,
                    });

                    return file;
                }
            }
                catch
            {
                return null;
            }
        }
        public async Task<MediaFile> PickPicture()
        {
            try
            {
                await CrossMedia.Current.Initialize();

                if (!CrossMedia.Current.IsPickPhotoSupported)
                {
                    return null;
                }
                else
                {
                    var file = await CrossMedia.Current.PickPhotoAsync();

                    if (file == null)
                    {
                        return null;
                    }
                    return file;
                }
            }
            catch
            {
                return null;
            }
    }
    }
}
