using DependecyServicesXamarin.Services;
using DependecyServicesXamarin.ViewModels;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace DependecyServicesXamarin.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public string DeviceOrientation { get; set; }
        public DelegateCommand GetOrientationCommand { get; set; }

        public MainViewModel()
        {
            GetOrientationCommand = new DelegateCommand(GetOrientation);
        }

        void GetOrientation()
        {
            var service = DependencyService.Get<IDeviceOrientationService>();
            DeviceOrientation orientation = service.GetOrientation();
            DeviceOrientation = $"The orientation of the device currently is {orientation}";
        }
    }
}
