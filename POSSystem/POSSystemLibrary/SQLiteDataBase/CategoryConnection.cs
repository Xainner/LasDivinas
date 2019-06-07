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
    public static class CategoryConnection
    {

        private static string LoadConnectionString(string id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        //-----------METODOS SE BUSQUEDA DE CATEGORIA---------------------

        public static List<CategoryModel> SelectAllCategories()
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<CategoryModel>("SELECT * FROM Tbl_Category ORDER BY Name");
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static CategoryModel SelectCategoriesByID(CategoryModel categoryModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<CategoryModel>("SELECT * FROM Tbl_Category WHERE Id_Category = @Id_Category", categoryModel);
                    return output.Single();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<CategoryModel> SelectCategoriesByName(CategoryModel categoryModel)
        {
            try
            {
                CategoryModel auxModel = new CategoryModel()
                {
                    Name = $"%{ categoryModel.Name }%"
                };
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<CategoryModel>("SELECT * FROM Tbl_Category WHERE Name like @Name", auxModel);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static CategoryModel SelectCategoryByName(CategoryModel categoryModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<CategoryModel>("SELECT * FROM Tbl_Category WHERE Name = @Name", categoryModel);
                    return output.Single();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //-----------METODOS DE ACME DE LA CATEGORIA---------------------

        public static bool InsertCategory(CategoryModel categoryModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO Tbl_Category (Name) VALUES(@Name)", categoryModel);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteCategoryById(CategoryModel categoryModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("DELETE FROM Tbl_Category WHERE Id_Category = @Id_Category", categoryModel);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateCategoryById(CategoryModel categoryModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("UPDATE Tbl_Category SET Name = @Name WHERE Id_Category = @Id_Category", categoryModel);
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
