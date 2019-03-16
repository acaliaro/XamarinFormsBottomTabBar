using KioskWebApp.Droid;
using KioskWebApp.Interface;
using Plugin.CurrentActivity;
using Xamarin.Forms;

[assembly: Dependency(typeof(Orientation_Android))]
namespace KioskWebApp.Droid
{
    public class Orientation_Android : IOrientation
    {

        public void Landscape()
        {
            CrossCurrentActivity.Current.Activity.RequestedOrientation = Android.Content.PM.ScreenOrientation.Landscape;
        }

        public void ReverseLandscape()
        {
            CrossCurrentActivity.Current.Activity.RequestedOrientation = Android.Content.PM.ScreenOrientation.ReverseLandscape;
        }

        public void Portrait()
        {
            CrossCurrentActivity.Current.Activity.RequestedOrientation = Android.Content.PM.ScreenOrientation.Portrait  ;
        }

        public void Unspecified()
        {
            CrossCurrentActivity.Current.Activity.RequestedOrientation = Android.Content.PM.ScreenOrientation.Unspecified;
        }
    }
}