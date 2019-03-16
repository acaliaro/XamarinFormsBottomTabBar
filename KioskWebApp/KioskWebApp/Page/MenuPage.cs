using Behaviors;
using KioskWebApp.ViewModel;

using Xamarin.Forms;

namespace KioskWebApp.Pag
{
	public class MenuPage : ContentPage
	{
		public MenuPage (MenuViewModel.EnumAmbiente ambiente)
		{

            this.BindingContext = new MenuViewModel(ambiente);

            this.SetBinding(ContentPage.TitleProperty, "Titolo");

            Button buttonTest = Utility.UserInterface.CreateButton(AppResources.Test);
            buttonTest.SetBinding(Button.CommandProperty, "TestCommand");

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children = {
                    buttonTest
                }
            };

            InvokeCommandAction icaOnAppearing = new InvokeCommandAction();
            icaOnAppearing.SetBinding(InvokeCommandAction.CommandProperty, "OnAppearingCommand");
            EventHandlerBehavior ehbOnAppearing = new EventHandlerBehavior() { EventName = "Appearing" };
            ehbOnAppearing.Actions.Add(icaOnAppearing);

            InvokeCommandAction icaOnDisappearing = new InvokeCommandAction();
            icaOnDisappearing.SetBinding(InvokeCommandAction.CommandProperty, "OnDisappearingCommand");
            EventHandlerBehavior ehbOnDisappearing = new EventHandlerBehavior() { EventName = "Disappearing" };
            ehbOnDisappearing.Actions.Add(icaOnDisappearing);

            this.Behaviors.Add(ehbOnAppearing);
            this.Behaviors.Add(ehbOnDisappearing);
        }
	}
}