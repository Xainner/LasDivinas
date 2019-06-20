namespace UI.UserControls
{
    partial class UcProduct
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcProduct));
            this.ModifyButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.exentoRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.gravadoRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.ImgpictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.RotRightButton = new System.Windows.Forms.Button();
            this.RotLeftButton = new System.Windows.Forms.Button();
            this.SelectImageButton = new System.Windows.Forms.Button();
            this.lowerPriceTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.unityPriceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.stockTextBox = new MetroFramework.Controls.MetroTextBox();
            this.codeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BrandComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.SubcategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ModifyButton
            // 
            this.ModifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifyButton.Image = ((System.Drawing.Image)(resources.GetObject("ModifyButton.Image")));
            this.ModifyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModifyButton.Location = new System.Drawing.Point(1069, 609);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(107, 23);
            this.ModifyButton.TabIndex = 18;
            this.ModifyButton.Text = "Modificar";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.Location = new System.Drawing.Point(1182, 609);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(107, 23);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.Text = "Eliminar";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewButton.Location = new System.Drawing.Point(843, 609);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(107, 23);
            this.NewButton.TabIndex = 20;
            this.NewButton.Text = "Nuevo";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(956, 609);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(107, 23);
            this.AddButton.TabIndex = 21;
            this.AddButton.Text = "Guardar";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.AllowUserToAddRows = false;
            this.ProductDataGridView.AllowUserToDeleteRows = false;
            this.ProductDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Location = new System.Drawing.Point(964, 95);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.ReadOnly = true;
            this.ProductDataGridView.RowHeadersVisible = false;
            this.ProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDataGridView.Size = new System.Drawing.Size(325, 506);
            this.ProductDataGridView.TabIndex = 16;
            this.ProductDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataGridView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.IdLabel);
            this.groupBox1.Controls.Add(this.exentoRadioButton);
            this.groupBox1.Controls.Add(this.gravadoRadioButton);
            this.groupBox1.Controls.Add(this.ImgpictureBox);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(this.RotRightButton);
            this.groupBox1.Controls.Add(this.RotLeftButton);
            this.groupBox1.Controls.Add(this.SelectImageButton);
            this.groupBox1.Controls.Add(this.lowerPriceTextBox1);
            this.groupBox1.Controls.Add(this.unityPriceTextBox);
            this.groupBox1.Controls.Add(this.stockTextBox);
            this.groupBox1.Controls.Add(this.codeTextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.BrandComboBox);
            this.groupBox1.Controls.Add(this.CategoryComboBox);
            this.groupBox1.Controls.Add(this.SubcategoryComboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(5, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 535);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(914, 519);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(31, 13);
            this.IdLabel.TabIndex = 22;
            this.IdLabel.Text = "none";
            this.IdLabel.Visible = false;
            // 
            // exentoRadioButton
            // 
            this.exentoRadioButton.AutoSize = true;
            this.exentoRadioButton.Location = new System.Drawing.Point(282, 210);
            this.exentoRadioButton.Name = "exentoRadioButton";
            this.exentoRadioButton.Size = new System.Drawing.Size(58, 15);
            this.exentoRadioButton.TabIndex = 5;
            this.exentoRadioButton.Text = "Exento";
            this.exentoRadioButton.UseSelectable = true;
            // 
            // gravadoRadioButton
            // 
            this.gravadoRadioButton.AutoSize = true;
            this.gravadoRadioButton.Location = new System.Drawing.Point(209, 210);
            this.gravadoRadioButton.Name = "gravadoRadioButton";
            this.gravadoRadioButton.Size = new System.Drawing.Size(67, 15);
            this.gravadoRadioButton.TabIndex = 4;
            this.gravadoRadioButton.Text = "Gravado";
            this.gravadoRadioButton.UseSelectable = true;
            // 
            // ImgpictureBox
            // 
            this.ImgpictureBox.Location = new System.Drawing.Point(385, 27);
            this.ImgpictureBox.Name = "ImgpictureBox";
            this.ImgpictureBox.Size = new System.Drawing.Size(560, 399);
            this.ImgpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgpictureBox.TabIndex = 6;
            this.ImgpictureBox.TabStop = false;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.descriptionTextBox.CustomButton.Image = null;
            this.descriptionTextBox.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.descriptionTextBox.CustomButton.Name = "";
            this.descriptionTextBox.CustomButton.Size = new System.Drawing.Size(105, 105);
            this.descriptionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionTextBox.CustomButton.TabIndex = 1;
            this.descriptionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionTextBox.CustomButton.UseSelectable = true;
            this.descriptionTextBox.CustomButton.Visible = false;
            this.descriptionTextBox.Lines = new string[0];
            this.descriptionTextBox.Location = new System.Drawing.Point(192, 411);
            this.descriptionTextBox.MaxLength = 32767;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PasswordChar = '\0';
            this.descriptionTextBox.PromptText = "Ingrese la descripción del producto.";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.SelectionLength = 0;
            this.descriptionTextBox.SelectionStart = 0;
            this.descriptionTextBox.ShortcutsEnabled = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(167, 107);
            this.descriptionTextBox.TabIndex = 9;
            this.descriptionTextBox.UseSelectable = true;
            this.descriptionTextBox.WaterMark = "Ingrese la descripción del producto.";
            this.descriptionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // RotRightButton
            // 
            this.RotRightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RotRightButton.Image = ((System.Drawing.Image)(resources.GetObject("RotRightButton.Image")));
            this.RotRightButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RotRightButton.Location = new System.Drawing.Point(623, 432);
            this.RotRightButton.Name = "RotRightButton";
            this.RotRightButton.Size = new System.Drawing.Size(26, 23);
            this.RotRightButton.TabIndex = 20;
            this.RotRightButton.UseVisualStyleBackColor = true;
            this.RotRightButton.Click += new System.EventHandler(this.RotRightButton_Click);
            // 
            // RotLeftButton
            // 
            this.RotLeftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RotLeftButton.Image = ((System.Drawing.Image)(resources.GetObject("RotLeftButton.Image")));
            this.RotLeftButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RotLeftButton.Location = new System.Drawing.Point(687, 432);
            this.RotLeftButton.Name = "RotLeftButton";
            this.RotLeftButton.Size = new System.Drawing.Size(26, 23);
            this.RotLeftButton.TabIndex = 20;
            this.RotLeftButton.UseVisualStyleBackColor = true;
            this.RotLeftButton.Click += new System.EventHandler(this.RotLeftButton_Click);
            // 
            // SelectImageButton
            // 
            this.SelectImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectImageButton.Image = ((System.Drawing.Image)(resources.GetObject("SelectImageButton.Image")));
            this.SelectImageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelectImageButton.Location = new System.Drawing.Point(655, 432);
            this.SelectImageButton.Name = "SelectImageButton";
            this.SelectImageButton.Size = new System.Drawing.Size(26, 23);
            this.SelectImageButton.TabIndex = 20;
            this.SelectImageButton.UseVisualStyleBackColor = true;
            this.SelectImageButton.Click += new System.EventHandler(this.SelectImageButton_Click);
            // 
            // lowerPriceTextBox1
            // 
            this.lowerPriceTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.lowerPriceTextBox1.CustomButton.Image = null;
            this.lowerPriceTextBox1.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.lowerPriceTextBox1.CustomButton.Name = "";
            this.lowerPriceTextBox1.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.lowerPriceTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lowerPriceTextBox1.CustomButton.TabIndex = 1;
            this.lowerPriceTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lowerPriceTextBox1.CustomButton.UseSelectable = true;
            this.lowerPriceTextBox1.CustomButton.Visible = false;
            this.lowerPriceTextBox1.Lines = new string[0];
            this.lowerPriceTextBox1.Location = new System.Drawing.Point(192, 359);
            this.lowerPriceTextBox1.MaxLength = 32767;
            this.lowerPriceTextBox1.Name = "lowerPriceTextBox1";
            this.lowerPriceTextBox1.PasswordChar = '\0';
            this.lowerPriceTextBox1.PromptText = "Ingrese precio por mayor";
            this.lowerPriceTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lowerPriceTextBox1.SelectedText = "";
            this.lowerPriceTextBox1.SelectionLength = 0;
            this.lowerPriceTextBox1.SelectionStart = 0;
            this.lowerPriceTextBox1.ShortcutsEnabled = true;
            this.lowerPriceTextBox1.Size = new System.Drawing.Size(167, 25);
            this.lowerPriceTextBox1.TabIndex = 8;
            this.lowerPriceTextBox1.UseSelectable = true;
            this.lowerPriceTextBox1.WaterMark = "Ingrese precio por mayor";
            this.lowerPriceTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lowerPriceTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // unityPriceTextBox
            // 
            this.unityPriceTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.unityPriceTextBox.CustomButton.Image = null;
            this.unityPriceTextBox.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.unityPriceTextBox.CustomButton.Name = "";
            this.unityPriceTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.unityPriceTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.unityPriceTextBox.CustomButton.TabIndex = 1;
            this.unityPriceTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.unityPriceTextBox.CustomButton.UseSelectable = true;
            this.unityPriceTextBox.CustomButton.Visible = false;
            this.unityPriceTextBox.Lines = new string[0];
            this.unityPriceTextBox.Location = new System.Drawing.Point(192, 312);
            this.unityPriceTextBox.MaxLength = 32767;
            this.unityPriceTextBox.Name = "unityPriceTextBox";
            this.unityPriceTextBox.PasswordChar = '\0';
            this.unityPriceTextBox.PromptText = "Ingrese precio por unidad.";
            this.unityPriceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.unityPriceTextBox.SelectedText = "";
            this.unityPriceTextBox.SelectionLength = 0;
            this.unityPriceTextBox.SelectionStart = 0;
            this.unityPriceTextBox.ShortcutsEnabled = true;
            this.unityPriceTextBox.Size = new System.Drawing.Size(167, 25);
            this.unityPriceTextBox.TabIndex = 7;
            this.unityPriceTextBox.UseSelectable = true;
            this.unityPriceTextBox.WaterMark = "Ingrese precio por unidad.";
            this.unityPriceTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.unityPriceTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // stockTextBox
            // 
            this.stockTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.stockTextBox.CustomButton.Image = null;
            this.stockTextBox.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.stockTextBox.CustomButton.Name = "";
            this.stockTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.stockTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.stockTextBox.CustomButton.TabIndex = 1;
            this.stockTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.stockTextBox.CustomButton.UseSelectable = true;
            this.stockTextBox.CustomButton.Visible = false;
            this.stockTextBox.Lines = new string[0];
            this.stockTextBox.Location = new System.Drawing.Point(192, 253);
            this.stockTextBox.MaxLength = 32767;
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.PasswordChar = '\0';
            this.stockTextBox.PromptText = "Ingrese cantidad stock.";
            this.stockTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stockTextBox.SelectedText = "";
            this.stockTextBox.SelectionLength = 0;
            this.stockTextBox.SelectionStart = 0;
            this.stockTextBox.ShortcutsEnabled = true;
            this.stockTextBox.Size = new System.Drawing.Size(167, 25);
            this.stockTextBox.TabIndex = 6;
            this.stockTextBox.UseSelectable = true;
            this.stockTextBox.WaterMark = "Ingrese cantidad stock.";
            this.stockTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.stockTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // codeTextBox
            // 
            // 
            // 
            // 
            this.codeTextBox.CustomButton.Image = null;
            this.codeTextBox.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.codeTextBox.CustomButton.Name = "";
            this.codeTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.codeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.codeTextBox.CustomButton.TabIndex = 1;
            this.codeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.codeTextBox.CustomButton.UseSelectable = true;
            this.codeTextBox.CustomButton.Visible = false;
            this.codeTextBox.Lines = new string[0];
            this.codeTextBox.Location = new System.Drawing.Point(192, 29);
            this.codeTextBox.MaxLength = 32767;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.PasswordChar = '\0';
            this.codeTextBox.PromptText = "Ingrese el código del producto.";
            this.codeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.codeTextBox.SelectedText = "";
            this.codeTextBox.SelectionLength = 0;
            this.codeTextBox.SelectionStart = 0;
            this.codeTextBox.ShortcutsEnabled = true;
            this.codeTextBox.Size = new System.Drawing.Size(167, 25);
            this.codeTextBox.TabIndex = 0;
            this.codeTextBox.UseSelectable = true;
            this.codeTextBox.WaterMark = "Ingrese el código del producto.";
            this.codeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.codeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(9, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "   Subcategoría";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BrandComboBox
            // 
            this.BrandComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BrandComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandComboBox.FormattingEnabled = true;
            this.BrandComboBox.Location = new System.Drawing.Point(192, 74);
            this.BrandComboBox.Name = "BrandComboBox";
            this.BrandComboBox.Size = new System.Drawing.Size(167, 28);
            this.BrandComboBox.TabIndex = 1;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(192, 117);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(167, 28);
            this.CategoryComboBox.TabIndex = 2;
            this.CategoryComboBox.SelectedValueChanged += new System.EventHandler(this.CategoryComboBox_SelectedValueChanged);
            // 
            // SubcategoryComboBox
            // 
            this.SubcategoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SubcategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubcategoryComboBox.FormattingEnabled = true;
            this.SubcategoryComboBox.Location = new System.Drawing.Point(192, 159);
            this.SubcategoryComboBox.Name = "SubcategoryComboBox";
            this.SubcategoryComboBox.Size = new System.Drawing.Size(167, 28);
            this.SubcategoryComboBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(9, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "    Categoría";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(14, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "    Descripción";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(14, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "    Precio por Mayor";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(9, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "    Tipo de Impuesto";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(9, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "    Precio por Unidad";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(9, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "    Cantidad Disponible";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "    Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(9, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "    Marca";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 56);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 52);
            this.label1.TabIndex = 13;
            this.label1.Text = "Productos";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.SearchTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.SearchTextBox.CustomButton.Location = new System.Drawing.Point(303, 1);
            this.SearchTextBox.CustomButton.Name = "";
            this.SearchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SearchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchTextBox.CustomButton.TabIndex = 1;
            this.SearchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchTextBox.CustomButton.UseSelectable = true;
            this.SearchTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.SearchTextBox.Lines = new string[0];
            this.SearchTextBox.Location = new System.Drawing.Point(964, 66);
            this.SearchTextBox.MaxLength = 32767;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.PromptText = "Ingrese el código del producto";
            this.SearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.SelectionLength = 0;
            this.SearchTextBox.SelectionStart = 0;
            this.SearchTextBox.ShortcutsEnabled = true;
            this.SearchTextBox.ShowButton = true;
            this.SearchTextBox.ShowClearButton = true;
            this.SearchTextBox.Size = new System.Drawing.Size(325, 23);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.UseSelectable = true;
            this.SearchTextBox.WaterMark = "Ingrese el código del producto";
            this.SearchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.SearchTextBox_ButtonClick);
            // 
            // UcProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ProductDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTextBox);
            this.Name = "UcProduct";
            this.Size = new System.Drawing.Size(1294, 639);
            this.Load += new System.EventHandler(this.UcProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox descriptionTextBox;
        private MetroFramework.Controls.MetroTextBox stockTextBox;
        private MetroFramework.Controls.MetroTextBox codeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox SearchTextBox;
        private System.Windows.Forms.PictureBox ImgpictureBox;
        private System.Windows.Forms.Button SelectImageButton;
        private System.Windows.Forms.Button RotRightButton;
        private System.Windows.Forms.Button RotLeftButton;
        private MetroFramework.Controls.MetroTextBox unityPriceTextBox;
        private MetroFramework.Controls.MetroTextBox lowerPriceTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.ComboBox SubcategoryComboBox;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroRadioButton exentoRadioButton;
        private MetroFramework.Controls.MetroRadioButton gravadoRadioButton;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.ComboBox BrandComboBox;
    }
}
