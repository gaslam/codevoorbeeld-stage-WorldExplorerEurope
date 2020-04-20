using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WorldExplorerEurope.App.Domain.Services
{
    public interface ICameraService
    {
        Task<bool> CheckAndroidCameraPermissions();
        Task<MediaFile> TakePicture();
        Task<MediaFile> PickPicture();
    }
}
