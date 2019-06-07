using POSSystemLibrary.Models;
using POSSystemLibrary.SQLiteDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSystemLibrary.Management
{
    public static class BrandManagement
    {

        //-----------METODOS SE BUSQUEDA DE MARCAS---------------------

        public static List<BrandModel> SelectAllBrands()
        {
            try
            {
                return BrandConnection.SelectAllBrands();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<BrandModel> SelectBrandsByName(string name)
        {
            try
            {
                BrandModel brandModel = new BrandModel()
                {
                    Name = name
                };
                return BrandConnection.SelectBrandsByName(brandModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static BrandModel SelectBrandByName(string name)
        {
            try
            {
                BrandModel brandModel = new BrandModel()
                {
                    Name = name
                };
                return BrandConnection.SelectBrandByName(brandModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static BrandModel SelectBrandByID(int id)
        {
            try
            {
                BrandModel brandModel = new BrandModel()
                {
                    Id_Brand = id
                };
                return BrandConnection.SelectBrandByID(brandModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //-----------METODOS SE ACME DE LA MARCA---------------------

        public static bool InsertBrand(string name)
        {
            try
            {
                BrandModel brandModel = new BrandModel()
                {
                    Name = name
                };
                return BrandConnection.InsertBrand(brandModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateBrandById(int id, string name)
        {
            try
            {
                BrandModel brandModel = new BrandModel()
                {
                    Id_Brand = id,
                    Name = name
                };
                return BrandConnection.UpdateBrandById(brandModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteBrandById(int id)
        {
            try
            {
                BrandModel brandModel = new BrandModel()
                {
                    Id_Brand = id
                };
                return BrandConnection.DeleteBrandById(brandModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
