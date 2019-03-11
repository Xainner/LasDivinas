namespace UI.UserControls
{
    partial class UcClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcClients));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EmailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PhoneNumberTextBox = new MetroFramework.Controls.MetroTextBox();
            this.IdentificationTextBox = new MetroFramework.Controls.MetroTextBox();
            this.LastNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.NameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.IdTypeComboBox = new System.Windows.Forms.ComboBox();
            this.BornDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 56);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(22, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "    Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(22, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "    Apellidos";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(898, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "    Correo electrónico";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(479, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "    Identificación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(22, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "    Número Telefónico";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.IdLabel);
            this.groupBox1.Controls.Add(this.EmailTextBox);
            this.groupBox1.Controls.Add(this.PhoneNumberTextBox);
            this.groupBox1.Controls.Add(this.IdentificationTextBox);
            this.groupBox1.Controls.Add(this.LastNameTextBox);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.IdTypeComboBox);
            this.groupBox1.Controls.Add(this.BornDateTimePicker);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1284, 143);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.EmailTextBox.CustomButton.Image = null;
            this.EmailTextBox.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.EmailTextBox.CustomButton.Name = "";
            this.EmailTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.EmailTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EmailTextBox.CustomButton.TabIndex = 1;
            this.EmailTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EmailTextBox.CustomButton.UseSelectable = true;
            this.EmailTextBox.CustomButton.Visible = false;
            this.EmailTextBox.Lines = new string[0];
            this.EmailTextBox.Location = new System.Drawing.Point(1084, 27);
            this.EmailTextBox.MaxLength = 32767;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PasswordChar = '\0';
            this.EmailTextBox.PromptText = "Ingrese el correo electrónico.";
            this.EmailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EmailTextBox.SelectedText = "";
            this.EmailTextBox.SelectionLength = 0;
            this.EmailTextBox.SelectionStart = 0;
            this.EmailTextBox.ShortcutsEnabled = true;
            this.EmailTextBox.Size = new System.Drawing.Size(167, 25);
            this.EmailTextBox.TabIndex = 5;
            this.EmailTextBox.UseSelectable = true;
            this.EmailTextBox.WaterMark = "Ingrese el correo electrónico.";
            this.EmailTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EmailTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // PhoneNumberTextBox
            // 
            // 
            // 
            // 
            this.PhoneNumberTextBox.CustomButton.Image = null;
            this.PhoneNumberTextBox.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.PhoneNumberTextBox.CustomButton.Name = "";
            this.PhoneNumberTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.PhoneNumberTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PhoneNumberTextBox.CustomButton.TabIndex = 1;
            this.PhoneNumberTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PhoneNumberTextBox.CustomButton.UseSelectable = true;
            this.PhoneNumberTextBox.CustomButton.Visible = false;
            this.PhoneNumberTextBox.Lines = new string[0];
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(212, 97);
            this.PhoneNumberTextBox.MaxLength = 32767;
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.PasswordChar = '\0';
            this.PhoneNumberTextBox.PromptText = "Ingrese el número telefónico.";
            this.PhoneNumberTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PhoneNumberTextBox.SelectedText = "";
            this.PhoneNumberTextBox.SelectionLength = 0;
            this.PhoneNumberTextBox.SelectionStart = 0;
            this.PhoneNumberTextBox.ShortcutsEnabled = true;
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(167, 25);
            this.PhoneNumberTextBox.TabIndex = 5;
            this.PhoneNumberTextBox.UseSelectable = true;
            this.PhoneNumberTextBox.WaterMark = "Ingrese el número telefónico.";
            this.PhoneNumberTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PhoneNumberTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // IdentificationTextBox
            // 
            this.IdentificationTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.IdentificationTextBox.CustomButton.Image = null;
            this.IdentificationTextBox.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.IdentificationTextBox.CustomButton.Name = "";
            this.IdentificationTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.IdentificationTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.IdentificationTextBox.CustomButton.TabIndex = 1;
            this.IdentificationTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.IdentificationTextBox.CustomButton.UseSelectable = true;
            this.IdentificationTextBox.CustomButton.Visible = false;
            this.IdentificationTextBox.Lines = new string[0];
            this.IdentificationTextBox.Location = new System.Drawing.Point(669, 62);
            this.IdentificationTextBox.MaxLength = 32767;
            this.IdentificationTextBox.Name = "IdentificationTextBox";
            this.IdentificationTextBox.PasswordChar = '\0';
            this.IdentificationTextBox.PromptText = "Ingrese la identificación.";
            this.IdentificationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IdentificationTextBox.SelectedText = "";
            this.IdentificationTextBox.SelectionLength = 0;
            this.IdentificationTextBox.SelectionStart = 0;
            this.IdentificationTextBox.ShortcutsEnabled = true;
            this.IdentificationTextBox.Size = new System.Drawing.Size(167, 25);
            this.IdentificationTextBox.TabIndex = 5;
            this.IdentificationTextBox.UseSelectable = true;
            this.IdentificationTextBox.WaterMark = "Ingrese la identificación.";
            this.IdentificationTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.IdentificationTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // LastNameTextBox
            // 
            // 
            // 
            // 
            this.LastNameTextBox.CustomButton.Image = null;
            this.LastNameTextBox.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.LastNameTextBox.CustomButton.Name = "";
            this.LastNameTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.LastNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LastNameTextBox.CustomButton.TabIndex = 1;
            this.LastNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LastNameTextBox.CustomButton.UseSelectable = true;
            this.LastNameTextBox.CustomButton.Visible = false;
            this.LastNameTextBox.Lines = new string[0];
            this.LastNameTextBox.Location = new System.Drawing.Point(212, 62);
            this.LastNameTextBox.MaxLength = 32767;
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.PasswordChar = '\0';
            this.LastNameTextBox.PromptText = "Ingrese el apellido del cliente.";
            this.LastNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LastNameTextBox.SelectedText = "";
            this.LastNameTextBox.SelectionLength = 0;
            this.LastNameTextBox.SelectionStart = 0;
            this.LastNameTextBox.ShortcutsEnabled = true;
            this.LastNameTextBox.Size = new System.Drawing.Size(167, 25);
            this.LastNameTextBox.TabIndex = 5;
            this.LastNameTextBox.UseSelectable = true;
            this.LastNameTextBox.WaterMark = "Ingrese el apellido del cliente.";
            this.LastNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LastNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // NameTextBox
            // 
            // 
            // 
            // 
            this.NameTextBox.CustomButton.Image = null;
            this.NameTextBox.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.NameTextBox.CustomButton.Name = "";
            this.NameTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.NameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NameTextBox.CustomButton.TabIndex = 1;
            this.NameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameTextBox.CustomButton.UseSelectable = true;
            this.NameTextBox.CustomButton.Visible = false;
            this.NameTextBox.Lines = new string[0];
            this.NameTextBox.Location = new System.Drawing.Point(212, 27);
            this.NameTextBox.MaxLength = 32767;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.PromptText = "Ingrese el nombre del cliente.";
            this.NameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.SelectionLength = 0;
            this.NameTextBox.SelectionStart = 0;
            this.NameTextBox.ShortcutsEnabled = true;
            this.NameTextBox.Size = new System.Drawing.Size(167, 25);
            this.NameTextBox.TabIndex = 5;
            this.NameTextBox.UseSelectable = true;
            this.NameTextBox.WaterMark = "Ingrese el nombre del cliente.";
            this.NameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // IdTypeComboBox
            // 
            this.IdTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IdTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTypeComboBox.FormattingEnabled = true;
            this.IdTypeComboBox.Location = new System.Drawing.Point(669, 27);
            this.IdTypeComboBox.Name = "IdTypeComboBox";
            this.IdTypeComboBox.Size = new System.Drawing.Size(167, 28);
            this.IdTypeComboBox.TabIndex = 4;
            // 
            // BornDateTimePicker
            // 
            this.BornDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BornDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BornDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BornDateTimePicker.Location = new System.Drawing.Point(669, 97);
            this.BornDateTimePicker.Name = "BornDateTimePicker";
            this.BornDateTimePicker.Size = new System.Drawing.Size(167, 26);
            this.BornDateTimePicker.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(479, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "    Tipo de Identificación";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(479, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "    Fecha de Nacimiento";
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(954, 606);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(107, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Agregar";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifyButton.Image = ((System.Drawing.Image)(resources.GetObject("ModifyButton.Image")));
            this.ModifyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModifyButton.Location = new System.Drawing.Point(1067, 606);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(107, 23);
            this.ModifyButton.TabIndex = 8;
            this.ModifyButton.Text = "Modificar";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewButton.Location = new System.Drawing.Point(841, 606);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(107, 23);
            this.NewButton.TabIndex = 8;
            this.NewButton.Text = "Nuevo";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.Location = new System.Drawing.Point(1180, 606);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(107, 23);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Eliminar";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1284, 357);
            this.dataGridView1.TabIndex = 4;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.SearchTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.SearchTextBox.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.SearchTextBox.CustomButton.Name = "";
            this.SearchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SearchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchTextBox.CustomButton.TabIndex = 1;
            this.SearchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchTextBox.CustomButton.UseSelectable = true;
            this.SearchTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.SearchTextBox.Lines = new string[0];
            this.SearchTextBox.Location = new System.Drawing.Point(1092, 214);
            this.SearchTextBox.MaxLength = 32767;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.PromptText = "Ingrese el nombre del cliente.";
            this.SearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.SelectionLength = 0;
            this.SearchTextBox.SelectionStart = 0;
            this.SearchTextBox.ShortcutsEnabled = true;
            this.SearchTextBox.ShowButton = true;
            this.SearchTextBox.ShowClearButton = true;
            this.SearchTextBox.Size = new System.Drawing.Size(195, 23);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.UseSelectable = true;
            this.SearchTextBox.WaterMark = "Ingrese el nombre del cliente.";
            this.SearchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.SearchTextBox_ButtonClick);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(1243, 127);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(31, 13);
            this.IdLabel.TabIndex = 6;
            this.IdLabel.Text = "none";
            this.IdLabel.Visible = false;
            // 
            // UcClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTextBox);
            this.Name = "UcClients";
            this.Size = new System.Drawing.Size(1294, 639);
            this.Load += new System.EventHandler(this.UcClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker BornDateTimePicker;
        private MetroFramework.Controls.MetroTextBox EmailTextBox;
        private MetroFramework.Controls.MetroTextBox PhoneNumberTextBox;
        private MetroFramework.Controls.MetroTextBox IdentificationTextBox;
        private MetroFramework.Controls.MetroTextBox LastNameTextBox;
        private MetroFramework.Controls.MetroTextBox NameTextBox;
        private System.Windows.Forms.ComboBox IdTypeComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox SearchTextBox;
        private System.Windows.Forms.Label IdLabel;
    }
}
