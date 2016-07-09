using System.IO;
using Xamarin.Forms;
using Windows.Storage;
using KonomiApp.UWP;
using KonomiApp;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SQLite;

[assembly: Dependency(typeof(SQLite_UWP))]

namespace KonomiApp.UWP
{
    public class SQLite_UWP : ISQLite; 
    {    
        public SQLite_UWP()
        {
        }

        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "TodoSQLite.db3";
            string path = Path.Combine(ApplicationData.Current.LocalFolder.Path, sqliteFilename);

            var conn = new SQLiteConnection(path);

            // Return the database connection 
            return conn;
        }
    }
}

