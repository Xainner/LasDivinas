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
    public static class SubcategoryConnection
    {
        private static string LoadConnectionString(string id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        //-----------METODOS SE BUSQUEDA DE SUBCATEGORIA---------------------

        public static List<SubcategoryModel> SelectAllSubCategories()
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<SubcategoryModel>("SELECT * FROM Tbl_Subcategory ORDER BY Name");
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<SubcategoryModel> SelectSubCategoriesByName(SubcategoryModel subCategoryModel)
        {
            try
            {
                SubcategoryModel auxModel = new SubcategoryModel()
                {
                    Name = $"%{ subCategoryModel.Name }%"
                };
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<SubcategoryModel>("SELECT * FROM Tbl_Subcategory WHERE Name like @Name", auxModel);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static SubcategoryModel SelectSubCategoryByName(SubcategoryModel subCategoryModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<SubcategoryModel>("SELECT * FROM Tbl_Subcategory WHERE Name = @Name", subCategoryModel);
                    return output.Single();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static List<SubcategoryModel> SelectSubCategoriesByCategoryId(SubcategoryModel subCategoryModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<SubcategoryModel>("SELECT * FROM Tbl_Subcategory WHERE Id_Category = @Id_Category ORDER BY Name", subCategoryModel);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static SubcategoryModel SelectSubCategoryById(SubcategoryModel subCategoryModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<SubcategoryModel>("SELECT * FROM Tbl_Subcategory WHERE Id_Subcategory = @Id_Subcategory", subCategoryModel);
                    return output.Single();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static List<ShowCatAndSubcatModel> SelectAllCatAndSucat()
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<ShowCatAndSubcatModel>("SELECT Id_Subcategory, C.Name as Category, S.Name as Subcategory " +
                        "FROM Tbl_Subcategory S INNER JOIN Tbl_Category C ON S.Id_Category = C.Id_Category ");
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<ShowCatAndSubcatModel> SearchSubcategory(ShowCatAndSubcatModel showCatAndSubcatModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<ShowCatAndSubcatModel>("SELECT Id_Subcategory, C.Name as Category, S.Name as Subcategory " +
                        "FROM Tbl_Subcategory S INNER JOIN Tbl_Category C ON S.Id_Category = C.Id_Category WHERE S.Name like @Subcategory", showCatAndSubcatModel);
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //-----------METODOS DE ACME DE LA SUBCATEGORIA---------------------

        public static bool InsertSubCategory(SubcategoryModel subCategoryModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO Tbl_Subcategory (Id_Category, Name) VALUES(@Id_Category, @Name)", subCategoryModel);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteSubCategoryById(SubcategoryModel subCategoryModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("DELETE FROM Tbl_Subcategory WHERE Id_Subcategory = @Id_Subcategory", subCategoryModel);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateSubCategoryById(SubcategoryModel subCategoryModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("UPDATE Tbl_Subcategory SET Name = @Name, Id_Category = @Id_Category WHERE Id_Subcategory = @Id_Subcategory", subCategoryModel);
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
