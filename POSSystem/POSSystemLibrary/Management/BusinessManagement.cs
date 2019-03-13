using POSSystemLibrary.Models;
using POSSystemLibrary.SQLiteDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSSystemLibrary.Management
{
    public static class BusinessManagement
    {
        /// <summary>
        /// Este metodo se encarga de modificar el unico neogicio 
        /// </summary>
        /// <param name="id">Id del neogicio seleccionado</param>
        /// <param name="societyName">Nombre del neogicio</param>
        /// <param name="legalCertification">Cedula juridica de el negocio</param>
        /// <param name="telephone">Telefono de el negocio</param>
        /// <param name="mainAddress">Direccion de el negocio</param>
        /// <param name="email">Email del negocio</param>
        /// <param name="webPage">Pagina web de el negocio/param>
        /// <param name="logo">Logo de el negocio</param>
        /// <returns>Envia una peticion a la capa DB para ver si puede modificar el negocio</returns>

        public static bool UpdateBusinessById(int id, string name, string societyName, string legalCertification, string telephone, string mainAddress, string email, string webPage, byte[] logo)
        {
            try
            {
                BusinessModel businessModel = new BusinessModel()
                {
                    Id_Business = id,
                    Society_Name = societyName,
                    LegalCertification = legalCertification,
                    Telephone = telephone,
                    Main_Address = mainAddress,
                    Email = email,
                    WebPage = webPage,
                    Logo = logo
                };
                return BusinessConnection.UpdateBusinessById(businessModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
