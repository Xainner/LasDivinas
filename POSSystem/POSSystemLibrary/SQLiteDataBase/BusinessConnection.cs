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

        /// <summary>
        /// Este metodo se encarga de consultarle a la BD hacer de si cuenta con los valores del negocio
        /// de acuerdo al texto ingresado, que sean similares al nombre, nombre de sociedad o cedula juridica.
        /// </summary>
        /// <param name="employeeModel">Recibe el objeto negocio</param>
        /// <returns>Devuelve la lista de negocios encontrados con similitudes en la DB</returns>

        public static List<BusinessModel> SelectMultipleBusiness(BusinessModel businessModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    businessModel.Name = $"%{ businessModel.Name }%";
                    businessModel.Society_Name = $"%{ businessModel.Society_Name }%";
                    businessModel.LegalCertification = $"%{ businessModel.LegalCertification }%";
                    var output = cnn.Query<BusinessModel>("SELECT * FROM Tbl_Business WHERE Name like @Name OR Society_Name like @Society_Name OR LegalCertification like @LegalCertification", businessModel);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //------- OTROS TIPOS DE CONSULTAS A LA BASE DE DATOS ---------

        /// <summary>
        /// Este metodo se encarga de buscar todos los negocios guardados en la base de datos 
        /// </summary>
        /// <returns>Devuelve la lista de negocios encontrados en la DB</returns>

        public static List<BusinessModel> SelectAllBusinesses()
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<BusinessModel>("SELECT * FROM Tbl_Business");
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
