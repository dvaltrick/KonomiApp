using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace KonomiApp
{
    public class UserData
    {
        SQLiteConnection database;

        public UserData() {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<User>();
        }

        public IEnumerable<User> GetItems()
        {
           return (from i in database.Table<User>() select i).ToList(); 
        }

        public IEnumerable<User> GetItemsNotDone()
        {
           return database.Query<User>("SELECT * FROM [User] WHERE [Done] = 0"); 
        }

        public bool existeUsuario() {
            var qry = database.Query<User>("SELECT * FROM [User]");
            if (qry.Count > 0)
            {
                return true;
            }
            else {
                return false;
            }

        }

        public User retornaUsuario() {
            var qry = database.Query<User>("SELECT * FROM [User]");
            if (qry.Count > 0)
            {
                return qry[0];
            }
            else {
                return null;
            }
            
        }

        public User GetItem(int id)
        {
           return database.Table<User>().FirstOrDefault(x => x.ID == id); 
        }

        public int SaveItem(User item)
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
            return database.Delete<User>(id);
        }
    }
}
