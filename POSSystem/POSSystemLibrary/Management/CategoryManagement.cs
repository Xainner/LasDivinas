using POSSystemLibrary.Models;
using POSSystemLibrary.SQLiteDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSystemLibrary.Management
{
    public static class CategoryManagement
    {
        //-----------METODOS SE BUSQUEDA DE CATEGORIAS---------------------

        public static List<CategoryModel> SelectAllCategories()
        {
            try
            {
                return CategoryConnection.SelectAllCategories();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<CategoryModel> SelectCategoriesByName(string name)
        {
            try
            {
                CategoryModel categoryModel = new CategoryModel()
                {
                    Name = name
                };
                return CategoryConnection.SelectCategoriesByName(categoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static CategoryModel SelectCategoryByID(string id)
        {
            try
            {
                CategoryModel categoryModel = new CategoryModel()
                {
                    Id_Category = int.Parse(id)
                };
                return CategoryConnection.SelectCategoriesByID(categoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static CategoryModel SelectCategoryByName(string name)
        {
            try
            {
                CategoryModel categoryModel = new CategoryModel()
                {
                    Name = name
                };
                return CategoryConnection.SelectCategoryByName(categoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //-----------METODOS SE ACME DE LA CATEGORIA---------------------

        public static bool InsertCategory(string name)
        {
            try
            {
                CategoryModel categoryModel = new CategoryModel()
                {
                    Name = name
                };
                return CategoryConnection.InsertCategory(categoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool UpdateCategoryById(int id, string name)
        {
            try
            {
                CategoryModel categoryModel = new CategoryModel()
                {
                    Id_Category = id,
                    Name = name
                };
                return CategoryConnection.UpdateCategoryById(categoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteCategoryById(int id)
        {
            try
            {
                CategoryModel categoryModel = new CategoryModel()
                {
                    Id_Category = id
                };
                return CategoryConnection.DeleteCategoryById(categoryModel);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
