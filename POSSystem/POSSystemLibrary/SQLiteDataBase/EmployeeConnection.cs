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

        //------------- METODOS ACME DE EMPLEADOS ------------------------

        /// <summary>
        /// Este metodo se encarga de insertar directamente en la base de datos los valores del empleado
        /// </summary>
        /// <param name="employeeModel">Recibe un objeto modelo para obtener los valores del empleado</param>
        /// <returns>Devuelve verdadero si se agrega el empleado y si falla falso</returns>

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

        /// <summary>
        /// Este metodo se encarga de actualizar los valores en la base de datos del empleado por medio del ID
        /// </summary>
        /// <param name="employeeModel">Recibe un objeto modelo para obtener los valores del empleado</param>
        /// <returns>Devuelve verdadero si se modifica el empleado y si falla falso</returns>

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

        /// <summary>
        /// Este metodo se encarga de consultarle a la BD hacer de si cuenta con los valores del empleado
        /// de acuerdo al texto ingresado, que sean similares al nombre, apellido o identificacion.
        /// </summary>
        /// <param name="employeeModel">Recibe el objeto empleado</param>
        /// <returns>Devuelve la lista de empleados encontrados con similitudes en la DB</returns>

        public static List<EmployeeModel> SelectMultipleEmployees(EmployeeModel employeeModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    employeeModel.Name = $"%{ employeeModel.Name }%";
                    employeeModel.LastName = $"%{ employeeModel.LastName }%";
                    employeeModel.Identification = $"%{ employeeModel.Identification }%";
                    var output = cnn.Query<EmployeeModel>("SELECT * FROM Tbl_Employee WHERE Name like @Name OR LastName like @LastName OR Identification like @Identification", employeeModel);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Este metodo se encarga de elimiar de la base de datos el empleado por medio del ID
        /// </summary>
        /// <param name="employeeModel">Recibe un objeto modelo para obtener los valores del empleado</param>
        /// <returns>Devuelve verdadero si se elimino el empleado y si falla falso</returns>

        public static bool DeleteEmployeeById(EmployeeModel employeeModel)
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

        //------- OTROS TIPOS DE CONSULTAS A LA BASE DE DATOS ---------

        /// <summary>
        /// Este metodo se encarga de buscar todos los empleados guardados en la base de datos 
        /// </summary>
        /// <returns>Devuelve la lista de empleados encontrados en la DB</returns>

        public static List<EmployeeModel> SelectAllEmployees()
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<EmployeeModel>("SELECT * FROM Tbl_Employee");
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
