using KonomiApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace KonomiApp
{
    public class FirstPage : ContentPage
    {
        User user = new User();

        public FirstPage()
        {
            verificaUsuario();
            trataBarraNavegacao();

            View view = new xBarCodeScanView();
            View menu = new xMenu();
            
            Content = new StackLayout
            {
                BackgroundColor = Color.FromHex("#eeeeee"),
                Children = {
                    menu,
                    view

                }
            };
        }

        private void verificaUsuario()
        {
            if (!App.Database.existeUsuario()) {
                Navigation.PushAsync(new xNewUser());
            }
            user = App.Database.retornaUsuario();
        }

        public void trataBarraNavegacao() {
            BackgroundColor = Color.White;
            Title = "Konomi";

            ToolbarItems.Add(new ToolbarItem("Check-in", "marker.png", async () =>
            {
                var page = new ContentPage();
                var result = await page.DisplayAlert("Title", "Message", "Accept", "Cancel");
            }));
        }

    }
}
