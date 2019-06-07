using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POSSystemLibrary.Management;
using MetroFramework;
using UI.Utilities;
using POSSystemLibrary.Models;

namespace UI.UserControls
{
    public partial class UcProduct : UserControl
    {
        //--------GLOBAR VARIABLES

        string auxImage;
        List<BrandModel> brandModels;
        List<ShowProductModel> showProducts;
        List<CategoryModel> categoryModels;

        public UcProduct()
        {
            InitializeComponent();
        }

        //----------------LIMPIAR LOS CAMPOS----------------------

        public void CleanProduct()
        {
            codeTextBox.Text = "";
            descriptionTextBox.Text = "";
            BrandComboBox.SelectedIndex = 0;
            CategoryComboBox.SelectedIndex = 0;
            SubcategoryComboBox.SelectedIndex = 0;
            stockTextBox.Text = "";
            unityPriceTextBox.Text = "";
            lowerPriceTextBox1.Text = "";
            gravadoRadioButton.Checked = true;
            ImgpictureBox.Image = null;
            IdLabel.Text = "none";

            ReloadProduct();
        }

        private void ReloadProduct()
        {
            showProducts = ProductManagement.SelectAllProducts();
            ProductDataGridView.DataSource = showProducts;
            ProductDataGridView.MultiSelect = false;

            ProductDataGridView.Columns["Id_Product"].HeaderText = "Id";
            ProductDataGridView.Columns["Code"].HeaderText = "Código";
            ProductDataGridView.Columns["Brand"].HeaderText = "Marca";
            ProductDataGridView.Columns["SubCategory"].HeaderText = "Sub-Categoría";
            ProductDataGridView.Columns["Description"].HeaderText = "Descripción";
            ProductDataGridView.Columns["Quantity_Stock"].HeaderText = "Stock";
            ProductDataGridView.Columns["Price"].HeaderText = "Precio Detalle";
            ProductDataGridView.Columns["Lower_Price"].HeaderText = "Precio Mayor";
            ProductDataGridView.Columns["Image"].HeaderText = "Imagen";
            ProductDataGridView.Columns["Ivi"].HeaderText = "Ivi";

            ProductDataGridView.Columns["Id_Product"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductDataGridView.Columns["Code"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductDataGridView.Columns["Brand"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductDataGridView.Columns["SubCategory"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductDataGridView.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductDataGridView.Columns["Quantity_Stock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductDataGridView.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductDataGridView.Columns["Lower_Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductDataGridView.Columns["Ivi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            ProductDataGridView.Columns["Id_Product"].Visible = false;
            ProductDataGridView.Columns["Image"].Visible = false;
            ProductDataGridView.Columns["Ivi"].Visible = false;

        }

        //Carga datos de inicio

        private void UcProduct_Load(object sender, EventArgs e)
        {
            ReloadProduct();

            brandModels = BrandManagement.SelectAllBrands();
            BrandComboBox.DataSource = brandModels;
            BrandComboBox.DisplayMember = "Name";

            categoryModels = CategoryManagement.SelectAllCategories();
            CategoryComboBox.DataSource = categoryModels;
            CategoryComboBox.DisplayMember = "Name";

            gravadoRadioButton.Checked = true;
        }

        //----------------METODOS DE ACME---------------

        private void NewButton_Click(object sender, EventArgs e)
        {
            CleanProduct();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            BrandModel brand = (BrandModel)BrandComboBox.SelectedItem;
            SubcategoryModel subcategory = (SubcategoryModel)SubcategoryComboBox.SelectedItem;
            bool taxes = true;

            if (exentoRadioButton.Checked)
            {
                taxes = false;
            }

            try
            {
                if (!string.IsNullOrEmpty(codeTextBox.Text) && ProductManagement.SelectProductByCode(codeTextBox.Text) == null)
                {
                    if (!string.IsNullOrEmpty(stockTextBox.Text))
                    {
                        if (!string.IsNullOrEmpty(unityPriceTextBox.Text))
                        {
                            if (!string.IsNullOrEmpty(descriptionTextBox.Text))
                            {
                                if (ProductManagement.InsertProduct(codeTextBox.Text, brand.Id_Brand.ToString(), subcategory.Id_Subcategory.ToString(), descriptionTextBox.Text,
                                        stockTextBox.Text, unityPriceTextBox.Text, lowerPriceTextBox1.Text, ImageManagement.ImageToByte(ImageManagement.TemporaryImage(ImgpictureBox.Image)), taxes))
                                {
                                    FrmMain.Instance.ToolStripLabel.Text = "Producto agregado de manera exitosa.";
                                    CleanProduct();
                                }
                                else
                                {
                                    MetroMessageBox.Show(this, $"Ha ocurrido un error al agregar el producto. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "La descripción no puede estar vacía.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "El precio no puede ser vacía.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "La catidad stock no puede ser vacía", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "El código de el producto no puede estar vacío, ni puede ser repetido.", "Error en el código", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {

            BrandModel brand = (BrandModel)BrandComboBox.SelectedItem;
            SubcategoryModel subcategory = (SubcategoryModel)SubcategoryComboBox.SelectedItem;
            bool taxes = true;

            if (exentoRadioButton.Checked)
            {
                taxes = false;
            }

            try
            {
                if (!string.IsNullOrEmpty(codeTextBox.Text) && (ProductManagement.SelectProductByCode(codeTextBox.Text) == null ||
                    ProductManagement.SelectProductByCode(codeTextBox.Text).Id_Product == int.Parse(ProductDataGridView.CurrentRow.Cells[0].Value.ToString())) && !IdLabel.Text.Equals("none"))
                {
                    if (!string.IsNullOrEmpty(descriptionTextBox.Text))
                    {
                        if (!string.IsNullOrEmpty(lowerPriceTextBox1.Text))
                        {
                            if (!string.IsNullOrEmpty(unityPriceTextBox.Text))
                            {
                                if (MetroMessageBox.Show(this, $"¿Seguro que desea modificar el Producto?", "Modificar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    if (ProductManagement.UpdateProductById(IdLabel.Text, codeTextBox.Text, brand.Id_Brand.ToString(), subcategory.Id_Subcategory.ToString(), stockTextBox.Text, descriptionTextBox.Text,
                                        unityPriceTextBox.Text, lowerPriceTextBox1.Text, ImageManagement.ImageToByte(ImageManagement.TemporaryImage(ImgpictureBox.Image)), taxes))
                                    {
                                        FrmMain.Instance.ToolStripLabel.Text = "Producto modificado de manera exitosa.";
                                        CleanProduct();
                                    }
                                    else
                                    {
                                        MetroMessageBox.Show(this, $"Ha ocurrido un error al modificar el Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "El precio por unidad no puede estar vacío.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "El precio por mayor no puede estar vacío.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "La descripción no puede ser vacía.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "El Código no puede estar vacío, ni puede ser repetido.", "Error en el código", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                FrmMain.Instance.ToolStripLabel.Text = "Error: " + ex.Message;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string id = ProductDataGridView.CurrentRow.Cells[0].Value.ToString();

                if (!string.IsNullOrEmpty(codeTextBox.Text) && !string.IsNullOrEmpty(unityPriceTextBox.Text))
                {
                    if (MetroMessageBox.Show(this, $"¿Seguro que desea eliminar el Producto?", "Eliminar Prodcuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (ProductManagement.DeleteProductById(id))
                        {
                            FrmMain.Instance.ToolStripLabel.Text = "Producto eliminado de manera exitosa.";
                            CleanProduct();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, $"Ha ocurrido un error al eliminar el Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Debe seleccionar un Producto para poder eliminarlo.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                FrmMain.Instance.ToolStripLabel.Text = "Error: " + ex.Message;
            }
        }

        //----------------METODOS DE SELECCION DE FOTO---------------

        private void SelectImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog()
                {
                    Title = "Seleccione el logo",
                    Multiselect = false
                })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        auxImage = ImageManagement.TemporaryImage(Image.FromFile(openFileDialog.FileName));
                        ImgpictureBox.Load(auxImage);
                    }
                }
            }
            catch (Exception ex)
            {
                FrmMain.Instance.ToolStripLabel.Text = "Error: " + ex.Message;
            }
        }

        private void RotLeftButton_Click(object sender, EventArgs e)
        {
            try
            {
                RotateFlipType rp = RotateFlipType.Rotate90FlipXY;
                Image image = ImgpictureBox.Image;
                image.RotateFlip(rp);
                ImgpictureBox.Image = image;
            }
            catch (Exception ex)
            {
                FrmMain.Instance.ToolStripLabel.Text = "Error: " + ex.Message;
            }
        }

        private void RotRightButton_Click(object sender, EventArgs e)
        {
            try
            {
                RotateFlipType rp = RotateFlipType.Rotate90FlipNone;
                Image image = ImgpictureBox.Image;
                image.RotateFlip(rp);
                ImgpictureBox.Image = image;
            }
            catch (Exception ex)
            {
                FrmMain.Instance.ToolStripLabel.Text = "Error: " + ex.Message;
            }
        }

        //----------------METODOS CAMBIO DE VALOR DE EL COMBOBOX---------------

        private void CategoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            CategoryModel category = (CategoryModel)CategoryComboBox.SelectedItem;
            SubcategoryComboBox.DataSource = SubcategoryManagement.SelectSubCategoriesByCategoryId(category.Id_Category);
            SubcategoryComboBox.DisplayMember = "Name";
            SubcategoryComboBox.ValueMember = "Id_Category";
        }

        //----------------METODOS DATA GRID VIEW DE EL PRODUCTO---------------

        private void ProductDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdLabel.Text = ProductDataGridView.CurrentRow.Cells[0].Value.ToString();

            try
            {
                if (ProductDataGridView.SelectedRows[0] != null)
                {
                    ProductModel productModel = ProductManagement.SelectProductByID(ProductDataGridView.CurrentRow.Cells["Id_Product"].Value.ToString());
                    
                    codeTextBox.Text = Convert.ToString(productModel.Code); ;
                    descriptionTextBox.Text = productModel.Description;
                    stockTextBox.Text = Convert.ToString(productModel.Quantity_Stock);
                    unityPriceTextBox.Text = Convert.ToString(productModel.Price);
                    lowerPriceTextBox1.Text = Convert.ToString(productModel.Lower_Price);

                    foreach (BrandModel item in BrandComboBox.Items)
                    {
                        int idBrand = productModel.Id_Brand;
                        if (item.Id_Brand == idBrand)
                        {
                            BrandComboBox.SelectedItem = item;
                        }
                    }

                    foreach (CategoryModel item2 in CategoryComboBox.Items)
                    {
                        SubcategoryModel sub = SubcategoryManagement.SelectSubCategoryById(productModel.Id_Subcategory);
                        CategoryModel cat = CategoryManagement.SelectCategoryByID(sub.Id_Category.ToString());
                        if (item2.Id_Category == sub.Id_Category)
                        {
                            CategoryComboBox.SelectedItem = item2;
                            foreach (SubcategoryModel item in SubcategoryComboBox.Items)
                            {
                                if (item.Id_Subcategory == sub.Id_Subcategory)
                                {
                                    SubcategoryComboBox.SelectedItem = item;
                                }
                            }
                        }
                    }

                    if (productModel.Image == null)
                    {
                        ImgpictureBox.Image = null;
                    }
                    else
                    {
                        ImgpictureBox.Image = ImageManagement.ByteToImage(productModel.Image);
                    }

                    if (productModel.Ivi)
                    {
                        gravadoRadioButton.Select();
                    }
                    else
                    {
                        exentoRadioButton.Select();
                    }
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, $"Ha ocurrido un error al seleccionar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
