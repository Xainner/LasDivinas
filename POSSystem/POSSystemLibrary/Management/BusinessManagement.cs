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
        //------------- METODOS DE ACTUALIZAR Y CONSULTAR DEL NEGOCIO --------------------

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

        /// <summary>
        /// Este metodo se encarga de buscar un negocio por medio del texto ingresado
        /// </summary>
        /// <param name="text">Texto ingresado por el usuario, que puede ser el nombre, nombre de sociedad o cedula juridica del negocio.</param>
        /// <returns>Envia una peticion a la capa DB para ver si puede encontrar las similitudes del texto con los negocios.</returns>

        public static List<BusinessModel> SelectMultipleBusiness(string text)
        {
            try
            {
                BusinessModel businessModel = new BusinessModel()
                {
                    Name = text,
                    Society_Name = text,
                    LegalCertification = text
                };
                return BusinessConnection.SelectMultipleBusiness(businessModel);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //------- OTROS TIPOS DE CONSULTAS AL NEGOCIO EN LA BASE DE DATOS ---------

        /// <summary>
        /// Metodo para consultar todos los negocio en la base de datos
        /// </summary>
        /// <returns>Envia una peticion a la capa DB para obtener todos los negocios en la DB</returns>

        public static List<BusinessModel> SelectAllBusiness()
        {
            try
            {
                return BusinessConnection.SelectAllBusinesses();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
