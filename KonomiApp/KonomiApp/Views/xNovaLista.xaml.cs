using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace KonomiApp.Views
{
    public partial class xNovaLista : ContentPage
    {
        public xNovaLista()
        {
            InitializeComponent();
        }

        public void btConfirmaOnClick(Object sender, EventArgs args)
        {
            if (nomeLista.Text != null)
            {
                ListaCompra lista = new ListaCompra();
                lista.NomeLista = nomeLista.Text;

                App.DatabaseListaCompra.SaveItem(lista);

                
                base.OnBackButtonPressed();
            }
            else
            {
                DisplayAlert("Erro", "Informe o nome da lista antes de continuar.", "Ok");
            }
        }

        public void btCancelOnClick(Object sender, EventArgs args)
        {
            base.OnBackButtonPressed();
        }
    }
}
