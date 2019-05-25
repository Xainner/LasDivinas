using POSSystemLibrary.Models;
using POSSystemLibrary.SQLiteDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSSystemLibrary.Management
{
    public class EmployeeManagement
    {
        //------- EMPLOYEE ACCIONS CREATE, MODIFY, DELETE ---------

        /// <summary>
        /// Este metodo se encarga de agregar los empleados
        /// </summary>
        /// <param name="name">Nombre del empleado</param>
        /// <param name="lastName">Apellido del empleado</param>
        /// <param name="phoneNumber">Número de Teléfono del empleado</param>
        /// <param name="idType">Tipo de identificación del empleado</param>
        /// <param name="identification">Identificación del empleado</param>
        /// <param name="bornDate">Fecha de nacimiento del empleado</param>
        /// <returns>Envia una peticion a la capa DB para ver si puede agregar el empleado</returns>

        public static bool InsertEmployee(string name, string lastName, string phoneNumber, string idType, string identification, DateTime bornDate, DateTime fechaRegistro)
        {
            try
            {
                EmployeeModel employeeModel = new EmployeeModel()
                {
                    Name = name,
                    LastName = lastName,
                    Telephone = phoneNumber,
                    Identification_Type = idType,
                    Identification = identification,
                    Born_Date = bornDate,
                    Registration_Date = fechaRegistro
                };
                return EmployeeConnection.InsertEmployee(employeeModel);
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        /// <summary>
        /// Este metodo se encarga de modificar el empleado seleccionado por el ID
        /// </summary>
        /// <param name="id">Id del empleado seleccionado</param>
        /// <param name="name">Nombre del empleado</param>
        /// <param name="lastName">Apellido del empleado</param>
        /// <param name="phoneNumber">Número de Teléfono del empleado</param>
        /// <param name="idType">Tipo de identificación del empleado</param>
        /// <param name="identification">Identificación del empleado</param>
        /// <param name="email">Email del empleado</param>
        /// <param name="bornDate">Fecha de nacimiento del empleado</param>
        /// <returns>Envia una peticion a la capa DB para ver si puede modificar el empleado</returns>

        public static bool UpdateEmployeeById(int id, string name, string lastName, string phoneNumber, string idType, string identification, DateTime bornDate)
        {
            try
            {
                EmployeeModel employeeModel = new EmployeeModel()
                {
                    Id_Employee = id,
                    Name = name,
                    LastName = lastName,
                    Telephone = phoneNumber,
                    Identification_Type = idType,
                    Identification = identification,
                    Born_Date = bornDate
                };
                return EmployeeConnection.UpdateEmployeeById(employeeModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Este metodo se encarga de buscar un empleado por medio del texto ingresado
        /// </summary>
        /// <param name="text">Texto ingresado por el usuario, que puede ser el nombre, apellido o identificacion del empleado.</param>
        /// <returns>Envia una peticion a la capa DB para ver si puede encontrar las similitudes del texto con los empleado.</returns>

        public static List<EmployeeModel> SelectMultipleEmployees(string text)
        {
            try
            {
                EmployeeModel employeeModel = new EmployeeModel()
                {
                    Name = text,
                    LastName = text,
                    Identification = text
                };
                return EmployeeConnection.SelectMultipleEmployees(employeeModel);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Este metodo se encarga de eliminar el empleado seleccionado por el ID
        /// </summary>
        /// <param name="id">Id del empleado seleccionado</param>
        /// <returns>Envia una peticion a la capa DB para ver si puede empleado el empleado</returns>

        public static bool DeleteEmployeeById(int id)
        {
            try
            {
                EmployeeModel employeeModel = new EmployeeModel()
                {
                    Id_Employee = id
                };
                return EmployeeConnection.DeleteEmployeeById(employeeModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        //------- OTROS TIPOS DE CONSULTAS A LOS EMPLEADOS EN LA BASE DE DATOS ---------

        /// <summary>
        /// Metodo para consultar todos los empleados en la base de datos
        /// </summary>
        /// <returns>Envia una peticion a la capa DB para obtener todos los empleados en la DB</returns>

        public static List<EmployeeModel> SelectAllEmployees()
        {
            try
            {
                return EmployeeConnection.SelectAllEmployees();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
