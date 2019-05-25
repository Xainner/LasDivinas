namespace UI.UserControls
{
    partial class UcEmployee
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcEmployee));
            this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new MetroFramework.Controls.MetroTextBox();
            this.IdentificationTextBox = new MetroFramework.Controls.MetroTextBox();
            this.LastNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.NameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.IdTypeComboBox = new System.Windows.Forms.ComboBox();
            this.BornDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CleanButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.AllowUserToAddRows = false;
            this.EmployeeDataGridView.AllowUserToDeleteRows = false;
            this.EmployeeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGridView.Location = new System.Drawing.Point(3, 243);
            this.EmployeeDataGridView.MultiSelect = false;
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.ReadOnly = true;
            this.EmployeeDataGridView.RowHeadersVisible = false;
            this.EmployeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(1284, 357);
            this.EmployeeDataGridView.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.IdLabel);
            this.groupBox1.Controls.Add(this.PhoneNumberTextBox);
            this.groupBox1.Controls.Add(this.IdentificationTextBox);
            this.groupBox1.Controls.Add(this.LastNameTextBox);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.IdTypeComboBox);
            this.groupBox1.Controls.Add(this.BornDateTimePicker);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1284, 143);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
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
            this.IdTypeComboBox.Items.AddRange(new object[] {
            "Cédula",
            "Pasaporte",
            "Permiso de trabajo",
            "Residencia"});
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 56);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 52);
            this.label1.TabIndex = 9;
            this.label1.Text = "Empleados";
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
            this.SearchTextBox.PromptText = "Ingrese nombre del empleado.";
            this.SearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.SelectionLength = 0;
            this.SearchTextBox.SelectionStart = 0;
            this.SearchTextBox.ShortcutsEnabled = true;
            this.SearchTextBox.ShowButton = true;
            this.SearchTextBox.ShowClearButton = true;
            this.SearchTextBox.Size = new System.Drawing.Size(195, 23);
            this.SearchTextBox.TabIndex = 13;
            this.SearchTextBox.UseSelectable = true;
            this.SearchTextBox.WaterMark = "Ingrese nombre del empleado.";
            this.SearchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.SearchTextBox_ButtonClick);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.Image")));
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateButton.Location = new System.Drawing.Point(1067, 606);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(107, 23);
            this.UpdateButton.TabIndex = 14;
            this.UpdateButton.Text = "Modificar";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.Location = new System.Drawing.Point(1180, 606);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(107, 23);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Eliminar";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CleanButton
            // 
            this.CleanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CleanButton.Image = ((System.Drawing.Image)(resources.GetObject("CleanButton.Image")));
            this.CleanButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CleanButton.Location = new System.Drawing.Point(841, 606);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(107, 23);
            this.CleanButton.TabIndex = 16;
            this.CleanButton.Text = "Nuevo";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.Location = new System.Drawing.Point(954, 606);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(107, 23);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Guardar";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // UcEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EmployeeDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTextBox);
            this.Name = "UcEmployee";
            this.Size = new System.Drawing.Size(1294, 639);
            this.Load += new System.EventHandler(this.UcEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView EmployeeDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label IdLabel;
        private MetroFramework.Controls.MetroTextBox PhoneNumberTextBox;
        private MetroFramework.Controls.MetroTextBox IdentificationTextBox;
        private MetroFramework.Controls.MetroTextBox LastNameTextBox;
        private MetroFramework.Controls.MetroTextBox NameTextBox;
        private System.Windows.Forms.ComboBox IdTypeComboBox;
        private System.Windows.Forms.DateTimePicker BornDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox SearchTextBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.Button SaveButton;
    }
}
