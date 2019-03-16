using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace KioskWebApp.Utility
{
    public static class UserInterface
    {
        public static string BUTTON_COLOR = "#ff0d00";
        public static string BAR_ITEM_COLOR = "#66FFFFFF";
        public static string BAR_BACKGROUND_COLOR = "#2196F3";
        private static string BUTTON_BORDER_COLOR = "#1a14ce";

        public static Button CreateButton(string text)
        {
            Button button = new Button() { Text = text, FontSize = 20, TextColor = Color.White, Margin = new Thickness(10,0), HorizontalOptions = LayoutOptions.FillAndExpand, HeightRequest = 60 , BackgroundColor = Color.FromHex(BUTTON_COLOR), BorderWidth = 2, BorderColor = Color.FromHex(BUTTON_BORDER_COLOR) };

            return button;
        }
    }
}
