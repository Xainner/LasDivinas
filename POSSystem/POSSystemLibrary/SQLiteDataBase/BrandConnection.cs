using Dapper;
using POSSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSystemLibrary.SQLiteDataBase
{
    public static class BrandConnection
    {

        private static string LoadConnectionString(string id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        //-----------METODOS SE BUSQUEDA DE MARCAS---------------------

        public static List<BrandModel> SelectAllBrands()
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<BrandModel>("SELECT * FROM Tbl_Brand ORDER BY Name");
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<BrandModel> SelectBrandsByName(BrandModel brandModel)
        {
            try
            {
                brandModel.Name = $"%{ brandModel.Name }%";
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<BrandModel>("SELECT * FROM Tbl_Brand WHERE Name like @Name", brandModel);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static BrandModel SelectBrandByName(BrandModel brandModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<BrandModel>("SELECT * FROM Tbl_Brand WHERE Name = @Name", brandModel);
                    return output.Single();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static BrandModel SelectBrandByID(BrandModel brandModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<BrandModel>("SELECT * FROM Tbl_Brand WHERE Id_Brand = @IdBrand", brandModel);
                    return output.Single();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //-----------METODOS SE ACME DE LA MARCA---------------------

        public static bool InsertBrand(BrandModel brandModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO Tbl_Brand(Name) VALUES(@Name)", brandModel);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteBrandById(BrandModel brandModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("DELETE FROM Tbl_Brand WHERE Id_Brand = @Id_Brand", brandModel);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateBrandById(BrandModel brandModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("UPDATE Tbl_Brand SET Name = @Name WHERE Id_Brand = @Id_Brand", brandModel);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
