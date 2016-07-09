using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KonomiApp
{
    public class ListaCompraData
    {
        SQLiteConnection database;

        public ListaCompraData()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<ListaCompra>();
        }

        public IEnumerable<ListaCompra> GetListas()
        {
            return database.Query<ListaCompra>("SELECT * FROM [ListaCompra] ");
        }

        public List<ListaCompra> GetTodasListas()
        {
            return database.Query<ListaCompra>("SELECT * FROM [ListaCompra] ");
        }

        public int SaveItem(ListaCompra item)
        {

            if (item.ID != 0)
            {
                database.Update(item);
                return item.ID;
            }
            else
            {
                return database.Insert(item);
            }

        }

        public int DeleteItem(int id)
        {
            return database.Delete<ListaCompra>(id);
        }
    }

}
