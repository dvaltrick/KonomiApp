using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Xamarin.Forms;

/* DATABASE
 * u717772537_diego  - oZGxbuQl9ssdxVYLDj
 */

namespace KonomiApp
{
    public class App : Application
    {
        static UserData database;
        static ListaCompraData dbListaCompra;

        public App()
        {
            // The root page of your application
            var mainNav = new NavigationPage(new FirstPage());
            mainNav.BarBackgroundColor = Color.FromHex("#43A047");//#43A047 //#009688
            mainNav.BarTextColor = Color.White;
            
            MainPage = mainNav;
            
        }

        public static UserData Database
        {
            get
            {
                if (database == null)
                {
                    database = new UserData();
                }
                return database;
            }
        }

        public static ListaCompraData DatabaseListaCompra
        {
            get
            {
                if (dbListaCompra == null)
                {
                    dbListaCompra = new ListaCompraData();
                }
                return dbListaCompra;
            }
        }

        public int ResumeAtTodoId { get; set; }

        protected override void OnStart()
        {
            // Handle when your app starts
            
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
