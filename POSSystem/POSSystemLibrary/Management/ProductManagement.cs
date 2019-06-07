using POSSystemLibrary.Models;
using POSSystemLibrary.SQLiteDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSystemLibrary.Management
{
    public static class ProductManagement
    {

        //-----------------METODOS ACME DEL PRODUCTO ---------------------------

        // AGREGAR PRODUCTO

        public static bool InsertProduct(
            string code,
            string idBrand,
            string idSubcategory,
            string Description,
            string Stock,
            string Price,
            string lowerPrice,
            byte[] image,
            bool ivi
        )
        {
            try
            {
                string[] Product = new string[] {
                    code,
                    idBrand,
                    idSubcategory,
                    Description,
                    Stock,
                    Price,
                    lowerPrice
                };
                ProductModel productModel = new ProductModel()
                {
                    Code = code,
                    Id_Brand = int.Parse(idBrand),
                    Id_Subcategory = int.Parse(idSubcategory),
                    Description = Description,
                    Quantity_Stock = int.Parse(Stock),
                    Price = decimal.Parse(Price),
                    Lower_Price = decimal.Parse(lowerPrice),
                    Ivi = ivi,
                    Image = image
                };

                return ProductConnection.InsertProduct(productModel);
            }
            catch (Exception ex)
            {
                //Log4Net
                return false;
            }
        }

        // ACTUALIZAR PRODUCTO

        public static bool UpdateProductById(
            string idProduct,
            string code,
            string idBrand,
            string idSubCategory,
            string stock,
            string Description,
            string Price,
            string lowerPrice,
            byte[] image,
            bool ivi
        )
        {
            try
            {
                string[] product = new string[] {
                    idProduct,
                    code,
                    idBrand,
                    idSubCategory,
                    stock,
                    Description,
                    Price,
                    lowerPrice
                };
                ProductModel productModel = new ProductModel()
                {
                    Id_Product = int.Parse(idProduct),
                    Code = code,
                    Id_Brand = int.Parse(idBrand),
                    Id_Subcategory = int.Parse(idSubCategory),
                    Quantity_Stock = int.Parse(stock),
                    Description = Description,
                    Price = decimal.Parse(Price),
                    Lower_Price = decimal.Parse(lowerPrice),
                    Ivi = ivi,
                    Image = image

                };
                return ProductConnection.UpdateProductById(productModel);
            }
            catch (Exception ex)
            {
                //Log4Net
                return false;
            }
        }

        /// <summary>
        /// Medoto para actualizar la cantidad de productos en la base de datos (stock)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="stock"></param>
        /// <returns></returns>

        public static bool UpdateProductById2(string id, string stock)
        {
            try
            {
                string[] product = new string[] {
                    id,
                    stock
                };
                ProductModel productModel = new ProductModel()
                {
                    Id_Product = Convert.ToInt32(id),
                    Quantity_Stock = int.Parse(stock)

                };
                return ProductConnection.UpdateProductById2(productModel);
            }
            catch (Exception ex)
            {
                //Log4Net
                return false;
            }
        }

        /// <summary>
        /// Metodo para eliminar un producto
        /// </summary>
        /// <param name="idProduct"></param>
        /// <returns></returns>

        public static bool DeleteProductById(string idProduct)
        {
            try
            {
                string[] product = new string[] { idProduct };
                ProductModel productModel = new ProductModel()
                {
                    Id_Product = int.Parse(idProduct),
                };
                return ProductConnection.DeleteProductById(productModel);
            }
            catch (Exception ex)
            {
                //Log4Net
                return false;
            }
        }

        //---------------METODOS DE BUSQUEDA DE PRODUCTOS

        public static List<ShowProductModel> SelectAllProducts()
        {
            try
            {
                return ProductConnection.SelectAllProducts();
            }
            catch (Exception ex)
            {
                //Log4Net
                return null;
            }
        }

        public static ProductModel SelectProductByCode(string code)
        {
            try
            {
                ProductModel productModel = new ProductModel()
                {
                    Code = code
                };
                return ProductConnection.SelectProductByCode(productModel);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static ProductModel SelectProductByID(string id)
        {
            try
            {
                ProductModel productModel = new ProductModel()
                {
                    Id_Product = int.Parse(id)
                };
                return ProductConnection.SelectProductByID(productModel);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
