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

        //------- CLIENT ACCIONS CREATE, MODIFY, DELETE ---------

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

        public static bool InsertClient(string name, string lastName, string idType, string identification, string email, DateTime bornDate)
        {
            try
            {
                ClientModel clientModel = new ClientModel()
                {
                    Name = name,
                    Lastname = lastName,
                    Identification_Type = idType,
                    Email = email,
                    Identification = identification,
                    Born_Date = bornDate
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
                    Lastname = lastName,
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
    }
}
