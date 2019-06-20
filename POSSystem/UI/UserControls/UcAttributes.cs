using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSSystemLibrary.Models;
using POSSystemLibrary.Management;
using MetroFramework;

namespace UI.UserControls
{
    public partial class UcAttributes : UserControl
    {
        //---------VARIABLES GLOBALES---------
        List<BrandModel> brandModels;
        List<CategoryModel> categoryModels;
        List<SubcategoryModel> subCategoryModels;
        List<ShowCatAndSubcatModel> showCatAndSubcats;

        public UcAttributes()
        {
            InitializeComponent();
        }

        private void UcAttributes_Load(object sender, EventArgs e)
        {
            ReloadBrandsDataGridView();
            ReloadCategoryComboBox();
            ReloadCategoryDataGridView();
            ReloadSubCategoriesDataGridView();
            //ShowSubcategories();
        }

        //--------METODOS DE RECARGA DE DATOS DE LOS ATRIBUTOS----------------

        private void ReloadBrandsDataGridView()
        {
            brandModels = BrandManagement.SelectAllBrands();
            BrandDataGridView.MultiSelect = false;
            BrandDataGridView.DataSource = brandModels;

            BrandDataGridView.Columns["Id_Brand"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            BrandDataGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrandDataGridView.Columns["Id_Brand"].HeaderText = "Id";
            BrandDataGridView.Columns["Name"].HeaderText = "Nombre";

            BrandDataGridView.Columns["Id_Brand"].Visible = false;
        }

        private void ReloadCategoryComboBox()
        {
            CategoryComboBox.DataSource = CategoryManagement.SelectAllCategories();
            CategoryComboBox.DisplayMember = "Name";
        }

        private void ReloadCategoryDataGridView()
        {
            categoryModels = CategoryManagement.SelectAllCategories();
            CategoryDataGridView.MultiSelect = false;
            CategoryDataGridView.DataSource = categoryModels;

            CategoryDataGridView.Columns["Id_Category"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CategoryDataGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CategoryDataGridView.Columns["Id_Category"].HeaderText = "Id";
            CategoryDataGridView.Columns["Name"].HeaderText = "Categoría";

            CategoryDataGridView.Columns["Id_Category"].Visible = false;
        }

        private void ReloadSubCategoriesDataGridView()
        {

            showCatAndSubcats = SubcategoryManagement.SelectAllCatAndSucat();
            SubCategoryDataGridView.DataSource = showCatAndSubcats;
            SubCategoryDataGridView.MultiSelect = false;

            SubCategoryDataGridView.Columns["Id_Subcategory"].HeaderText = "ID";
            SubCategoryDataGridView.Columns["Category"].HeaderText = "Categoría";
            SubCategoryDataGridView.Columns["Subcategory"].HeaderText = "SubCategoría";

            SubCategoryDataGridView.Columns["Id_Subcategory"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SubCategoryDataGridView.Columns["Category"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SubCategoryDataGridView.Columns["Subcategory"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            SubCategoryDataGridView.Columns["Id_Subcategory"].Visible = false;
            SubCategoryDataGridView.MultiSelect = false;
        }

        private void ShowSubcategories()
        {
            try
            {
                subCategoryModels = SubcategoryManagement.SelectAllSubCategories();

                SubCategoryDataGridView.Rows.Clear();
                foreach (SubcategoryModel item2 in subCategoryModels)
                {
                    int Id = item2.Id_Subcategory;
                    CategoryModel category = CategoryManagement.SelectCategoryByID(item2.Id_Category.ToString());
                    string name = category.Name;
                    string Sub = item2.Name;
                    SubCategoryDataGridView.Rows.Add(Id, name, Sub);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //----------------METODOS ACME DE LA MARCA---------------------

        private void CleanBrandButton_Click(object sender, EventArgs e)
        {
            BrandNameTextBox.Text = "";
            ReloadBrandsDataGridView();
        }

        private void SaveBrandButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(BrandNameTextBox.Text))
                {
                    if (BrandManagement.SelectBrandByName(BrandNameTextBox.Text) == null)
                    {
                        if (BrandManagement.InsertBrand(BrandNameTextBox.Text))
                        {
                            FrmMain.Instance.ToolStripLabel.Text = "Se agrego el Empleado correctamente.";
                            BrandNameTextBox.Text = "";
                            ReloadBrandsDataGridView();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, $"Ha ocurrido un error al agregar la marca: { BrandNameTextBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Ya existe una marca con ese nombre.", "Marca repetida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "El campo del nombre de la marca no puede estar vacío.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void UpdateBrandButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (BrandDataGridView.Rows.Count != 0)
                {
                    if (!string.IsNullOrEmpty(BrandNameTextBox.Text))
                    {
                        if (MetroMessageBox.Show(this, $"¿Seguro que desea modificar la marca: { BrandDataGridView.CurrentRow.Cells[1].Value.ToString() }?", "Modificar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {

                            if (BrandManagement.UpdateBrandById(int.Parse(BrandDataGridView.CurrentRow.Cells[0].Value.ToString()), BrandNameTextBox.Text))
                            {
                                FrmMain.Instance.ToolStripLabel.Text = "Se agrego la Marca correctamente.";
                                BrandNameTextBox.Text = "";
                                ReloadBrandsDataGridView();
                            }
                            else
                            {
                                MetroMessageBox.Show(this, $"Ha ocurrido un error al modificar la marca: { BrandNameTextBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "No puede tener en blanco o vacio el nombre de marca.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
                else
                {
                    MetroMessageBox.Show(this, "Debe seleccionar una marca para poder modificarla.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void DeleteBrandButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (BrandDataGridView.Rows.Count != 0)
                {
                    if (MetroMessageBox.Show(this, $"¿Seguro que desea eliminar la marca: { BrandDataGridView.CurrentRow.Cells[1].Value.ToString() }?", "Eliminar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (BrandManagement.DeleteBrandById(int.Parse(BrandDataGridView.CurrentRow.Cells[0].Value.ToString())))
                        {
                            FrmMain.Instance.ToolStripLabel.Text = "Se elimino la Marca correctamente.";
                            BrandNameTextBox.Text = "";
                            ReloadBrandsDataGridView();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, $"Ha ocurrido un error al eliminar la marca: { BrandDataGridView.CurrentRow.Cells[1].Value.ToString()}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Debe seleccionar una marca para poder eliminarla.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void SearchBrandTextBox_ButtonClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SearchBrandTextBox.Text))
            {
                BrandDataGridView.DataSource = BrandManagement.SelectBrandsByName(SearchBrandTextBox.Text);
            }
            else
            {
                ReloadBrandsDataGridView();
            }
        }

        //Metodo de seleccion de en el datagridview de la marca
        private void BrandDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (BrandDataGridView.SelectedRows[0] != null)
            {
                BrandNameTextBox.Text = BrandDataGridView.CurrentRow.Cells[1].Value.ToString();
            }
        }

        //----------------METODOS ACME DE LA CATEGORIA---------------------

        private void CleanCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryNameTextBox.Text = "";
            ReloadCategoryDataGridView();
        }

        private void SaveCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(CategoryNameTextBox.Text))
                {
                    if (CategoryManagement.SelectCategoryByName(CategoryNameTextBox.Text) == null)
                    {
                        if (CategoryManagement.InsertCategory(CategoryNameTextBox.Text))
                        {
                            FrmMain.Instance.ToolStripLabel.Text = "Se agrego la Categoría correctamente.";
                            CategoryNameTextBox.Text = "";
                            ReloadCategoryDataGridView();
                            ReloadCategoryComboBox();
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Ya existe una categoría con ese nombre.", "Categoría repetida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "El campo del nombre de la categoría no puede estar vacío.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void UpdateCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategoryDataGridView.Rows.Count != 0)
                {
                    if (!string.IsNullOrEmpty(CategoryNameTextBox.Text))
                    {
                        if (MetroMessageBox.Show(this, $"¿Seguro que desea modificar la categoría: { CategoryDataGridView.CurrentRow.Cells[1].Value.ToString() }?", "Modificar categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            if (CategoryManagement.UpdateCategoryById(int.Parse(CategoryDataGridView.CurrentRow.Cells[0].Value.ToString()), CategoryNameTextBox.Text))
                            {
                                FrmMain.Instance.ToolStripLabel.Text = "Se actualizo la Categoría correctamente.";
                                CategoryNameTextBox.Text = "";
                                ReloadCategoryDataGridView();
                                ReloadCategoryComboBox();
                            }
                            else
                            {
                                MetroMessageBox.Show(this, $"Ha ocurrido un error al modificar la categoría: { CategoryDataGridView.CurrentRow.Cells[1].Value.ToString()}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "No puede estar vacio el campo nombre categoría.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Debe seleccionar una categoría para poder modificarla.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void DeleteCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategoryDataGridView.Rows.Count != 0)
                {
                    if (MetroMessageBox.Show(this, $"¿Seguro que desea eliminar la categoría: { CategoryDataGridView.CurrentRow.Cells[1].Value.ToString() }?", "Eliminar categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (CategoryManagement.DeleteCategoryById(int.Parse(CategoryDataGridView.CurrentRow.Cells[0].Value.ToString())))
                        {
                            FrmMain.Instance.ToolStripLabel.Text = "Se eliminó la Categoría correctamente.";
                            CategoryNameTextBox.Text = "";
                            ReloadCategoryDataGridView();
                            ReloadCategoryComboBox();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, $"Ha ocurrido un error al eliminar la categoría: { CategoryDataGridView.CurrentRow.Cells[1].Value.ToString()}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Debe seleccionar una categoría para poder eliminarla.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void SearchCategoryTextBox_ButtonClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SearchCategoryTextBox.Text))
            {
                CategoryDataGridView.DataSource = CategoryManagement.SelectCategoriesByName(SearchCategoryTextBox.Text);
            }
            else
            {
                ReloadCategoryDataGridView();
            }
        }

        //Metodo de seleccion de en el datagridview de la categoria
        private void CategoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CategoryDataGridView.SelectedRows[0] != null)
            {
                CategoryNameTextBox.Text = CategoryDataGridView.CurrentRow.Cells[1].Value.ToString();
            }
        }

        //----------------METODOS ACME DE LA SUBCATEGORIA---------------------

        private void CleanSubCategoryButton_Click(object sender, EventArgs e)
        {
            SubCategoryNameTextBox.Text = "";
            CategoryComboBox.SelectedIndex = 0;
            ReloadSubCategoriesDataGridView();
        }

        private void SaveSubCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(SubCategoryNameTextBox.Text))
                {
                    CategoryModel categoryModel = (CategoryModel)CategoryComboBox.SelectedItem;
                    List<SubcategoryModel> subcategory = SubcategoryManagement.SelectSubCategoriesByName(SubCategoryNameTextBox.Text);
                    Boolean var = true;

                    foreach (SubcategoryModel item in subcategory)
                    {
                        if (item.Id_Category == categoryModel.Id_Category)
                        {
                            var = false;
                        }
                    }

                    if (subcategory == null || var == true)
                    {
                        if (SubcategoryManagement.InsertSubCategory(categoryModel.Id_Category, SubCategoryNameTextBox.Text))
                        {
                            FrmMain.Instance.ToolStripLabel.Text = "Se agregó la Subcategoría correctamente.";
                            SubCategoryNameTextBox.Text = "";
                            CategoryComboBox.SelectedIndex = 0;
                            ReloadSubCategoriesDataGridView();
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Ya existe una subcategoría con ese nombre.", "subcategoría repetida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "El campo del nombre de la subcategoría no puede estar vacío.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void UpdateSubCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SubCategoryDataGridView.Rows.Count != 0)
                {
                    if (!string.IsNullOrEmpty(SubCategoryNameTextBox.Text))
                    {
                        if (MetroMessageBox.Show(this, $"¿Seguro que desea modificar la subcategoría: { SubCategoryDataGridView.CurrentRow.Cells[2].Value.ToString() }?", "Modificar subcategoría", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            int idCat = ((CategoryModel)CategoryComboBox.SelectedItem).Id_Category;
                            if (SubcategoryManagement.UpdateSubCategoryById(int.Parse(SubCategoryDataGridView.CurrentRow.Cells[0].Value.ToString()), idCat, SubCategoryNameTextBox.Text))
                            {
                                FrmMain.Instance.ToolStripLabel.Text = "Se actualizó la Subcategoría correctamente.";
                                SubCategoryNameTextBox.Text = "";
                                CategoryComboBox.SelectedIndex = 0;
                                ReloadSubCategoriesDataGridView();
                            }
                            else
                            {
                                MetroMessageBox.Show(this, $"Ha ocurrido un error al modificar la subcategoría: { SubCategoryDataGridView.CurrentRow.Cells[2].Value.ToString()}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "No puede estar vacio el campo nombre subcategoría.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Debe seleccionar una subcategoría para poder modificarla.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void DeleteSubCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SubCategoryDataGridView.Rows.Count != 0)
                {
                    if (MetroMessageBox.Show(this, $"¿Seguro que desea eliminar la subcategoría: { SubCategoryDataGridView.CurrentRow.Cells[2].Value.ToString() }?", "Eliminar subcategoría", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (SubcategoryManagement.DeleteSubCategoryById(int.Parse(SubCategoryDataGridView.CurrentRow.Cells[0].Value.ToString())))
                        {
                            FrmMain.Instance.ToolStripLabel.Text = "Se eliminó la Subcategoría correctamente.";
                            SubCategoryNameTextBox.Text = "";
                            CategoryComboBox.SelectedIndex = 0;
                            ReloadSubCategoriesDataGridView();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, $"Ha ocurrido un error al eliminar la subcategoría: { SubCategoryDataGridView.CurrentRow.Cells[2].Value.ToString()}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Debe seleccionar una subcategoría para poder eliminarla.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void SearchSubCategoryTextBox_ButtonClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SearchSubCategoryTextBox.Text))
            {
                SubCategoryDataGridView.DataSource = SubcategoryManagement.SearchSubcategory(SearchSubCategoryTextBox.Text);
            }
            else
            {
                ReloadSubCategoriesDataGridView();
            }
        }

        private void SubCategoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SubCategoryDataGridView.Rows.Count != 0)
            {
                SubCategoryNameTextBox.Text = SubCategoryDataGridView.CurrentRow.Cells[2].Value.ToString();

                SubcategoryModel subCategoryModel = SubcategoryManagement.SelectSubCategoryById(int.Parse(SubCategoryDataGridView.CurrentRow.Cells[0].Value.ToString()));

                foreach (CategoryModel categoryModel in CategoryComboBox.Items)
                {
                    if (categoryModel.Id_Category == subCategoryModel.Id_Category)
                    {
                        CategoryComboBox.SelectedItem = categoryModel;
                        break;
                    }
                }
            }
        }
    }
}
