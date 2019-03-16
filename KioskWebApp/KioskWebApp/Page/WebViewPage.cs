using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace KioskWebApp.Page
{
    public class WebViewPage : ContentPage
    {
        public WebViewPage(string url)
        {

            
            WebView webView = new WebView() { Source = url, WidthRequest = 1000, HeightRequest = 1000 };
            Content = new StackLayout
            {
                VerticalOptions=LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children = {
                    webView
                }
            };
        }
    }
}