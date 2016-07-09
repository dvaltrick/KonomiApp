using KonomiApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace KonomiApp
{
    public class ListasPage : ContentPage
    {
        ListView lv;
        ObservableCollection<ListaCompra> aListas;

        public ListasPage()
        {    
            BackgroundColor = Color.White;
            Title = "Minhas Listas";

            ToolbarItems.Add(new ToolbarItem("Nova Lista", "Plus.png", async () =>
            {
                var page = new ContentPage();
                await Navigation.PushModalAsync(new xNovaLista());
            }));

            lv = new ListView();

            carregaLista();

            var cell = new DataTemplate(typeof(TextCell));
            cell.SetBinding(TextCell.TextProperty, "NomeLista");
            cell.SetValue(TextCell.TextColorProperty, Color.FromHex("#7C4DFF"));
            lv.ItemTemplate = cell;
            lv.BackgroundColor = Color.White;
            lv.SeparatorColor = Color.FromHex("#7C4DFF");




            Content = new StackLayout
            {
                BackgroundColor = Color.FromHex("#eeeeee"),
                Children = { lv}
                
            };
        }

        public void carregaLista()
        {
            aListas = new ObservableCollection<ListaCompra>();

            var query = App.DatabaseListaCompra.GetTodasListas();

            for (int i = 0; i < query.Count; i++)
            {
                aListas.Add(query[i]);
            }

            lv.ItemsSource = aListas;

        }

    }
}
