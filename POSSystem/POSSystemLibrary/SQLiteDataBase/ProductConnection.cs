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
    public class ProductConnection
    {
        private static string LoadConnectionString(string id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        //-----------------METODOS ACME DEL PRODUCTO--------------------------

        /// <summary>
        /// Metodo para insertar productos
        /// </summary>
        /// <param name="productModel"></param>
        /// <returns></returns>
        
        public static bool InsertProduct(ProductModel productModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {

                    cnn.Execute("INSERT INTO Tbl_Product (Code, Id_Brand, Id_Subcategory, Description, " +
                        "Quantity_Stock, Price, Lower_Price, Image, Ivi) VALUES" +
                        "(@Code, @Id_Brand, @Id_Subcategory, @Description, @Quantity_Stock, @Price, @Lower_Price, @Image, @Ivi)", productModel);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// Metodo para actualizar productos
        /// </summary>
        /// <param name="productModel"></param>
        /// <returns></returns>

        public static bool UpdateProductById(ProductModel productModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("UPDATE Tbl_Product SET Code = @Code, Id_Brand = @Id_Brand, " +
                        "Id_Subcategory = @Id_Subcategory, Description = @Description, Quantity_Stock = @Quantity_Stock, " +
                        "Price = @Price, Lower_Price = @Lower_Price, Image = @Image, " +
                        "Ivi = @Ivi WHERE Id_Product = @Id_Product", productModel);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// Metodo para actualizar el stock de productos disponibles
        /// </summary>
        /// <param name="productModel"></param>
        /// <returns></returns>

        public static bool UpdateProductById2(ProductModel productModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("UPDATE Tbl_Product SET Quantity_Stock = @Quantity_Stock WHERE Id_Product = @Id_Product", productModel);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productModel"></param>
        /// <returns></returns>

        public static bool DeleteProductById(ProductModel productModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("DELETE FROM Tbl_Product WHERE Id_Product = @Id_Product", productModel);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //-------------------CONSULTAS--------------------------------------------------


        public static List<ShowProductModel> SelectAllProducts()
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<ShowProductModel>("" +
                        "SELECT Id_Product, Code, B.Name as Brand, S.Name as Subcategory, Description, " +
                        "Quantity_Stock, Price, Lower_Price, Image, Ivi " +
                        "FROM Tbl_Product P INNER JOIN Tbl_Brand B ON P.Id_Brand = B.Id_Brand " +
                        "INNER JOIN Tbl_Subcategory S ON P.Id_Subcategory = S.Id_Subcategory");

                    //SELECT Id_Product, Code, Tbl_Brand.Name, Tbl_Subcategory.Name, Description, Quantity_Stock, Price, Lower_Price, Image, Ivi FROM Tbl_Product INNER JOIN Tbl_Brand ON Tbl_Product.Id_Brand = Tbl_Brand.Id_Brand INNER JOIN Tbl_Subcategory ON Tbl_Product.Id_Subcategory = Tbl_Subcategory.Id_Subcategory limit 20
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static List<ProductModel> SelectProductById(ProductModel productModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>("SELECT * FROM Tbl_Product WHERE Id_Product = @Id_Product", productModel);
                return output.ToList();
            }
        }

        public static ProductModel SelectProductByCode(ProductModel productModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>("SELECT * FROM Tbl_Product WHERE Code = @Code", productModel);
                return output.Single();
            }
        }

        public static ProductModel SelectProductByID(ProductModel productModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>("SELECT * FROM Tbl_Product WHERE Id_Product = @Id_Product", productModel);
                return output.Single();
            }
        }
    }
}
