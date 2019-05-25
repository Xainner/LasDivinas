using POSSystemLibrary.Models;
using POSSystemLibrary.SQLiteDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSSystemLibrary.Management
{
    public static class ClientManagement
    {

        //------- METODOS DEL CLIENTE CREAR, MODIFICAR, CONSULTAR Y ELIMINAR ---------

        /// <summary>
        /// Este metodo se encarga de agregar los clientes
        /// </summary>
        /// <param name="name">Nombre del Cliente</param>
        /// <param name="lastName">Apellido del Cliente</param>
        /// <param name="idType">Tipo de identificación del Cliente</param>
        /// <param name="identification">Identificación del Cliente</param>
        /// <param name="email">Email del Cliente</param>
        /// <param name="bornDate">Fecha de nacimiento del Cliente</param>
        /// <returns>Envia una peticion a la capa DB para ver si puede agregar el cliente</returns>

        public static bool InsertClient(string name, string lastName, string idType, string identification, string email, DateTime bornDate, DateTime registrationDate)
        {
            try
            {
                ClientModel clientModel = new ClientModel()
                {
                    Name = name,
                    LastName = lastName,
                    Identification_Type = idType,
                    Email = email,
                    Identification = identification,
                    Born_Date = bornDate,
                    Registration_Date = registrationDate
                };
                return ClientConnection.InsertClient(clientModel);
            }
            catch (Exception ex)
            {
                
            }
            return false;
        }

        /// <summary>
        /// Este metodo se encarga de modificar el cliente seleccionado por el ID
        /// </summary>
        /// <param name="id">Id del Cliente seleccionado</param>
        /// <param name="name">Nombre del Cliente</param>
        /// <param name="lastName">Apellido del Cliente</param>
        /// <param name="idType">Tipo de identificación del Cliente</param>
        /// <param name="identification">Identificación del Cliente</param>
        /// <param name="email">Email del Cliente</param>
        /// <param name="bornDate">Fecha de nacimiento del Cliente</param>
        /// <returns>Envia una peticion a la capa DB para ver si puede modificar el cliente</returns>

        public static bool UpdateClientById(int id, string name, string lastName, string idType, string identification, string email, DateTime bornDate)
        {
            try
            {
                ClientModel clientModel = new ClientModel()
                {
                    Id_Client = id,
                    Name = name,
                    LastName = lastName,
                    Identification_Type = idType,
                    Email = email,
                    Identification = identification,
                    Born_Date = bornDate
                };
                return ClientConnection.UpdateClientById(clientModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Este metodo se encarga de buscar un cliente por medio del texto ingresado
        /// </summary>
        /// <param name="text">Texto ingresado por el usuario, que puede ser el nombre, apellido o identificacion del cliente.</param>
        /// <returns>Envia una peticion a la capa DB para ver si puede encontrar las similitudes del texto con los clientes.</returns>

        public static List<ClientModel> SelectMultipleClients(string text)
        {
            try
            {
                ClientModel clientModel = new ClientModel()
                {
                    Name = text,
                    LastName = text,
                    Identification = text
                };
                return ClientConnection.SelectMultipleClients(clientModel);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Este metodo se encarga de eliminar el cliente seleccionado por el ID
        /// </summary>
        /// <param name="id">Id del Cliente seleccionado</param>
        /// <returns>Envia una peticion a la capa DB para ver si puede eliminar el cliente</returns>

        public static bool DeleteClientById(int id)
        {
            try
            {
                ClientModel clientModel = new ClientModel()
                {
                    Id_Client = id
                };
                return ClientConnection.DeleteClientById(clientModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //------- OTROS TIPOS DE CONSULTAS AL CLIENTE EN LA BASE DE DATOS ---------

        /// <summary>
        /// Metodo para consultar todos los clientes en la base de datos
        /// </summary>
        /// <returns>Envia una peticion a la capa DB para obtener todos los clientes en la DB</returns>

        public static List<ClientModel> SelectAllClients()
        {
            try
            {
                return ClientConnection.SelectAllClients();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
