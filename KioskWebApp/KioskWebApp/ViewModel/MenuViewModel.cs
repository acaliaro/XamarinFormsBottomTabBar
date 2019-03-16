using KioskWebApp.Interface;
using KioskWebApp.Page;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace KioskWebApp.ViewModel
{
    public class MenuViewModel : INotifyPropertyChanged
    {

        bool _isTapped;

        public string Titolo { get; set; }

        enum EnumWebPage { Test};
        public enum EnumAmbiente { Prod, PreProd, Soluzione1}

        public MenuViewModel(EnumAmbiente ambiente)
        {

            Titolo = getTitolo(ambiente);

            TestCommand = new Command(async () => {

                await apriWebPage(ambiente, EnumWebPage.Test);
 
            });

            OnAppearingCommand = new Command(() => {

                DependencyService.Get<IOrientation>().Unspecified();
            });
        }

        private string getTitolo(EnumAmbiente ambiente)
        {

            switch(ambiente)
            {
                case EnumAmbiente.PreProd:
                    return AppResources.PreProduzione;
                case EnumAmbiente.Prod:
                    return AppResources.Produzione;
                case EnumAmbiente.Soluzione1:
                    return AppResources.Soluzione1;
                default:
                    return AppResources.AmbienteNonDefinito;
            }
        }

        private async Task apriWebPage(EnumAmbiente ambiente, EnumWebPage webPage)
        {
            try
            {
                if (_isTapped)
                    return;

                _isTapped = true;

                if(needLandscape(webPage))
                    DependencyService.Get<IOrientation>().ReverseLandscape();
                else
                    DependencyService.Get<IOrientation>().Portrait();

                await Application.Current.MainPage.Navigation.PushModalAsync(new WebViewPage(getUrl(ambiente, webPage)));

                _isTapped = false;
            }
            catch (Exception ex)
            {
                _isTapped = false;

                await Application.Current.MainPage.DisplayAlert(AppResources.Attenzione, ex.Message, AppResources.Ok);

            }
        }

        private bool needLandscape(EnumWebPage webPage)
        {
            return false;
        }

        private string getUrl(EnumAmbiente ambiente, EnumWebPage webPage)
        {
            switch(webPage)
            {
                default:
                    return "http://www.google.com";
            }
        }

        public ICommand TestCommand { get; protected set; }
        public ICommand OnAppearingCommand { get; protected set; }
        public ICommand OnDisappearingCommand { get; protected set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
