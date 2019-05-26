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

namespace UI.UserControls
{
    public partial class UcProduct : UserControl
    {
        public UcProduct()
        {
            InitializeComponent();
        }

        //----------------LIMPIAR LOS CAMPOS----------------------

        public void CleanProduct()
        {
            codeTextBox.Text = "";
            brandTextBox.Text = "";
            descriptionTextBox.Text = "";
            categoryTextBox.Text = "";
            typeiviComboBox.Text = "";
            stockTextBox.Text = "";
            priceTextBox1.Text = "";
        }

        private void UcProduct_Load(object sender, EventArgs e)
        {

        }

        //----------------METODOS DE ACME---------------

        private void NewButton_Click(object sender, EventArgs e)
        {
            CleanProduct();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(codeTextBox.Text) && ProductManagement.SelectProductByCode(codeTextBox.Text) == null)
                {
                    if (!string.IsNullOrEmpty(descriptionTextBox.Text))
                    {
                        if (!string.IsNullOrEmpty(stockTextBox.Text))
                        {
                            if (!string.IsNullOrEmpty(brandTextBox.Text))
                            {
                                if (!string.IsNullOrEmpty(priceTextBox1.Text))
                                {
                                    //if (ProductManagement.InsertProduct(codeTextBox.Text, brandTextBox.Text, descriptionTextBox.Text,
                                    //    descriptionTextBox.Text, priceTextBox1.Text, )
                                    //{
                                    //    FrmMain.Instance.ToolStripLabel.Text = "Producto agregado de manera exitosa.";
                                    //    CleanProduct();
                                    //}
                                    //else
                                    //{
                                    //    MetroMessageBox.Show(this, $"Ha ocurrido un error al agregar el producto. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    //}
                                }
                                else
                                {
                                    MetroMessageBox.Show(this, "El precio no puede ser vacío.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "La cantidad de entrada no puede estar vacía.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "La cantidad fija no puede estar vacía.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "La descripción no puede ser vacía", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "El Código no puede estar vacío, ni puede ser repetido.", "Error en el código", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(codeTextBox.Text) && (ProductManagement.SelectProductByCode(codeTextBox.Text) == null ||
                    ProductManagement.SelectProductByCode(codeTextBox.Text).Id_Product == int.Parse(ProductDataGridView.CurrentRow.Cells[0].Value.ToString())))
                {
                    if (!string.IsNullOrEmpty(descriptionTextBox.Text))
                    {
                        if (!string.IsNullOrEmpty(brandTextBox.Text))
                        {
                            if (!string.IsNullOrEmpty(categoryTextBox.Text))
                            {
                                if (!string.IsNullOrEmpty(priceTextBox1.Text))
                                {
                                    if (MetroMessageBox.Show(this, $"¿Seguro que desea modificar el Producto?", "Modificar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                    {
                                        //if (ProductManagement.UpdateProductById(codeTextBox.Text, brandTextBox.Text, categoryTextBox.Text, descriptionTextBox.Text,
                                        //    priceTextBox1.Text, 
                                        //    FrmMain.Instance.ToolStripLabel.Text = "Producto modificado de manera exitosa.";
                                        //    CleanProduct();
                                        //}
                                        //else
                                        //{
                                        //    MetroMessageBox.Show(this, $"Ha ocurrido un error al modificar el Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        //}
                                    }
                                }
                                else
                                {
                                    MetroMessageBox.Show(this, "El precio no puede ser vacío.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "La cantidad de entrada no puede estar vacía.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "La cantidad fija no puede estar vacía.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                if (!string.IsNullOrEmpty(codeTextBox.Text) && !string.IsNullOrEmpty(priceTextBox1.Text))
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
    }
}
