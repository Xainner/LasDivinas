using Dapper;
using POSSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace POSSystemLibrary.SQLiteDataBase
{
    public static class ClientConnection
    {
        private static string LoadConnectionString(string id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static bool InsertClient(ClientModel clientModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO Tbl_Client (Name, LastName, Identification_Type, Identification, Email, Born_Date) VALUES (@Name, @LastName, @identificationType, @Identification, @Email,  @Born_Date)", clientModel);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateClientById(ClientModel clientModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("UPDATE Tbl_Client SET Name = @Name, LastName = @LastName, Identification_Type = @Identification_Type, Identification = @Identification, Email = @Email, Born_Date = @Born_Date WHERE Id_Client = @Id_Client", clientModel);
                    return true;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteClientById(ClientModel clientModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("DELETE FROM Tbl_Client WHERE Id_Client = @Id_Client", clientModel);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
