using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace KonomiApp.Views
{
    public partial class xMenu : ContentView
    {
        public xMenu()
        {
            //#26A69A
            InitializeComponent();
        } 

        public void btListaOnClick(Object sender, EventArgs args){
            Navigation.PushAsync(new ListasPage());
        }
    }
}
