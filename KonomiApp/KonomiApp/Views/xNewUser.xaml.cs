using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace KonomiApp.Views
{
    public partial class xNewUser : ContentPage
    {
        public xNewUser() 
        {
            InitializeComponent(); 

            nome.Text = "";  
            email.Text = ""; 
        }

        public async void sendEmailOnClick(Object sender, EventArgs args)
        {
            if((nome.Text.Length > 0) || (email.Text.Length > 0))
            {
                var result = DisplayAlert(nome.Text,
                                                "Bem vindo ao Konomi! \n" +
                                                "Uma senha foi enviada para o email " + email.Text, 
                                                "Ok");
                User user = new User();
                user.Name  = nome.Text;
                user.Email = email.Text;
                user.Done = true;

                App.Database.SaveItem(user);

                base.OnBackButtonPressed();
            }
            else
            {
                var result = await DisplayAlert("Atenção",
                                                "Informe seu nome e email para continuar!",
                                                "Ok", "Cancelar");
            }
            
        }
    }
}
