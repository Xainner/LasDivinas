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
    public static class BusinessConnection
    {
        //------------- CARGAR LA CONEXION ---------------

        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        private static string LoadConnectionString(string id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        /// <summary>
        /// Este metodo se encarga de actualizar los valores en la base de datos de el negocio por medio del ID
        /// </summary>
        /// <param name="employeeModel">Recibe un objeto para obtener los valores del negocio</param>
        /// <returns>Devuelve verdadero si se modifica el negocio y si falla falso</returns>

        public static bool UpdateBusinessById(BusinessModel businessModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("UPDATE Tbl_Business " +
                        "SET Name = @Name, Society_Name = @Society_Name, LegalCertification = @LegalCertification, Telephone = @Telephone, " +
                        "Main_Address = @Main_Address, Email = @Email, webPage = @WebPage, Logo = @Logo " +
                        "WHERE Id_Business = @Id_Business", businessModel);
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
