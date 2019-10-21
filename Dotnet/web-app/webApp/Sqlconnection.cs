using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Microsoft.Data.Sqlite;
using webApp.Models;
using System.Configuration;
using webApp.Data;

namespace webApp
{
    public class Sqlconnection
    {

        public static List<User> LoadUsers(long id = 0)
        {

            if (id == 0) { 
                string queryString = "select * from APPUSERS";
                //ConnectionState string was not able to be get with the
                //    configuration manager, so i manually obteint from the file: appsettings.json
                return DoSelect(queryString);
            }else{
                string queryString = "select * from APPUSERS where ID = " + id;
                return DoSelect(queryString);
            }
        }

        private static List<User> DoSelect(String queryString) {
            using (IDbConnection cnn = new SqliteConnection("DataSource = app.db"))
            {

                var output = cnn.Query<User>(queryString, new DynamicParameters());
                return output.ToList();
            }
        }

        public static Boolean SaveUser(User user) {
            using (IDbConnection cnn = new SqliteConnection("DataSource = app.db"))
            {

                var output = cnn.Execute(
                    "Insert into APPUSERS (Name, Email, Phone, Message) values (@Name, @Email, @Phone, @Message)",
                    user
                    );
                return true;
            }
        }

        private static string LoadConnectionString(string id = "DefaultConnection") {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}
