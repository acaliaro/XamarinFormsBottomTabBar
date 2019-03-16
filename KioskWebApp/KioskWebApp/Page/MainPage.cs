using KioskWebApp.Pag;
using KioskWebApp.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
namespace KioskWebApp.Page
{
    public class MainPage : Xamarin.Forms.TabbedPage
    {
        public MainPage()
        {
            this.BarBackgroundColor = Color.FromHex(Utility.UserInterface.BAR_BACKGROUND_COLOR);
            this.BarTextColor = Color.White;

            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom).
                SetBarItemColor(Color.FromHex(Utility.UserInterface.BAR_ITEM_COLOR)).
                SetBarSelectedItemColor(Color.FromHex(Utility.UserInterface.BUTTON_COLOR));

            this.Children.Add(new MenuPage(MenuViewModel.EnumAmbiente.Prod));
            this.Children.Add(new MenuPage(MenuViewModel.EnumAmbiente.PreProd));
        }
    }
}