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
    public static class EmployeeConnection
    {
        private static string LoadConnectionString(string id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static bool InsertEmployee(EmployeeModel employeeModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO Tbl_Employee (Name, LastName, Telephone, Identification_Type, Identification, Born_Date) VALUES (@Name, @LastName, @Telephone, @Identification_Type, @Identification,  @Born_Date)", employeeModel);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateEmployeeById(EmployeeModel employeeModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("UPDATE Tbl_Employee SET Name = @Name, LastName = @LastName, Telephone = @Telephone, Identification_Type = @Identification_Type, Identification = @Identification, Born_Date = @Born_Date WHERE Id_Employee = @Id_Employee", employeeModel);
                    return true;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteClientById(EmployeeModel employeeModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("DELETE FROM Tbl_Employee WHERE Id_Employee = @Id_Employee", employeeModel);
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
