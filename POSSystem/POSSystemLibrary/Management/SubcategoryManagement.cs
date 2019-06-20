using POSSystemLibrary.Models;
using POSSystemLibrary.SQLiteDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSystemLibrary.Management
{
    public static class SubcategoryManagement
    {
        //-----------METODOS SE BUSQUEDA DE SUBCATEGORIAS---------------------

        public static List<SubcategoryModel> SelectAllSubCategories()
        {
            try
            {
                return SubcategoryConnection.SelectAllSubCategories();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<SubcategoryModel> SelectSubCategoriesByName(string name)
        {
            try
            {
                SubcategoryModel subCategoryModel = new SubcategoryModel()
                {
                    Name = name
                };
                return SubcategoryConnection.SelectSubCategoriesByName(subCategoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<SubcategoryModel> SelectSubCategoriesByCategoryId(int id)
        {
            try
            {
                SubcategoryModel subCategoryModel = new SubcategoryModel()
                {
                    Id_Category = id
                };
                return SubcategoryConnection.SelectSubCategoriesByCategoryId(subCategoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<ShowCatAndSubcatModel> SearchSubcategory(string name)
        {
            try
            {
                ShowCatAndSubcatModel showCatAndSubcatModel = new ShowCatAndSubcatModel()
                {
                    Subcategory = name
                };
                return SubcategoryConnection.SearchSubcategory(showCatAndSubcatModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static SubcategoryModel SelectSubCategoryById(int id)
        {
            try
            {
                SubcategoryModel subCategoryModel = new SubcategoryModel()
                {
                    Id_Subcategory = id
                };
                return SubcategoryConnection.SelectSubCategoryById(subCategoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<ShowCatAndSubcatModel> SelectAllCatAndSucat()
        {
            try
            {
                return SubcategoryConnection.SelectAllCatAndSucat();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }

        //-----------METODOS SE ACME DE LA SUBCATEGORIAS---------------------

        public static bool InsertSubCategory(int id, string name)
        {
            try
            {
                SubcategoryModel subCategoryModel = new SubcategoryModel()
                {
                    Id_Category = id,
                    Name = name
                };
                return SubcategoryConnection.InsertSubCategory(subCategoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateSubCategoryById(int id, int categoryId, string name)
        {
            try
            {
                SubcategoryModel subCategoryModel = new SubcategoryModel()
                {
                    Id_Subcategory = id,
                    Id_Category = categoryId,
                    Name = name
                };
                return SubcategoryConnection.UpdateSubCategoryById(subCategoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteSubCategoryById(int id)
        {
            try
            {
                SubcategoryModel subCategoryModel = new SubcategoryModel()
                {
                    Id_Subcategory = id
                };
                return SubcategoryConnection.DeleteSubCategoryById(subCategoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
