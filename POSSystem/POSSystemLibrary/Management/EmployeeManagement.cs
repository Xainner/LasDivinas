using POSSystemLibrary.Models;
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

        public static bool InsertEmployee(string name, string lastName, string phoneNumber, string idType, string identification, DateTime bornDate)
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
                    Born_Date = bornDate
                };
                return true; //EmployeeConnection.InsertEmployee(employeeModel);
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
                return true; // EmployeeConnection.UpdateEmployeeById(clientModel);
            }
            catch (Exception ex)
            {
                throw;
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
                return true; // EmployeeConnection.DeleteEmployeeyId(employeeModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
