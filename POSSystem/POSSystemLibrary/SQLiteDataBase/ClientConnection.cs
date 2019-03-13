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
        //------------- CARGAR LA CONEXION ---------------

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        private static string LoadConnectionString(string id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        //------------- METODOS ACME DEL CLIENTE ------------------------

        /// <summary>
        /// Este metodo se encarga de insertar directamente en la base de datos los valores del cliente
        /// </summary>
        /// <param name="employeeModel">Recibe un objeto modelo para obtener los valores del cliente</param>
        /// <returns>Devuelve verdadero si se agrega el cliente y si falla falso</returns>

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

        /// <summary>
        /// Este metodo se encarga de actualizar los valores en la base de datos del cliente por medio del ID
        /// </summary>
        /// <param name="employeeModel">Recibe un objeto modelo para obtener los valores del cliente</param>
        /// <returns>Devuelve verdadero si se modifica el cliente y si falla falso</returns>

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

        /// <summary>
        /// Este metodo se encarga de consultarle a la BD hacer de si cuenta con los valores del cliente
        /// de acuerdo al texto ingresado, que sean similares al nombre, apellido o identificacion.
        /// </summary>
        /// <param name="clientModel">Recibe el objeto cliente</param>
        /// <returns>Devuelve la lista de clientes encontrados con similitudes en la DB</returns>

        public static List<ClientModel> SelectMultipleClients(ClientModel clientModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    clientModel.Name = $"%{ clientModel.Name }%";
                    clientModel.LastName = $"%{ clientModel.LastName }%";
                    clientModel.Identification = $"%{ clientModel.Identification }%";
                    var output = cnn.Query<ClientModel>("SELECT * FROM Tbl_Client WHERE Name like @Name OR LastName like @LastName OR Identification like @Identification", clientModel);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Este metodo se encarga de elimiar de la base de datos el cliente por medio del ID
        /// </summary>
        /// <param name="employeeModel">Recibe un objeto modelo para obtener los valores del cliente</param>
        /// <returns>Devuelve verdadero si se elimino el cliente y si falla falso</returns>

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

        //------- OTROS TIPOS DE CONSULTAS A LA BASE DE DATOS ---------

        /// <summary>
        /// Este metodo se encarga de buscar todos los clientes guardados en la base de datos 
        /// </summary>
        /// <returns>Devuelve la lista de clientes encontrados en la DB</returns>

        public static List<ClientModel> SelectAllClients()
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<ClientModel>("SELECT * FROM Tbl_Client");
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
