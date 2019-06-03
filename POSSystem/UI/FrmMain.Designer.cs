namespace UI
{
    partial class FrmMain
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.DraggablePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AboutButton = new System.Windows.Forms.Button();
            this.MaximizeButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AdministrationButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.ClientsButton = new System.Windows.Forms.Button();
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.ProductButton = new System.Windows.Forms.Button();
            this.BusinessButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.AboutButton2 = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.PurchaseOrderButton = new System.Windows.Forms.Button();
            this.DraggablePanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DraggablePanel
            // 
            this.DraggablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.DraggablePanel.Controls.Add(this.label1);
            this.DraggablePanel.Controls.Add(this.AboutButton);
            this.DraggablePanel.Controls.Add(this.MaximizeButton);
            this.DraggablePanel.Controls.Add(this.MinimizeButton);
            this.DraggablePanel.Controls.Add(this.ExitButton);
            this.DraggablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DraggablePanel.Location = new System.Drawing.Point(0, 0);
            this.DraggablePanel.Name = "DraggablePanel";
            this.DraggablePanel.Size = new System.Drawing.Size(1318, 30);
            this.DraggablePanel.TabIndex = 0;
            this.DraggablePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DraggablePanel_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Facturación";
            // 
            // AboutButton
            // 
            this.AboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.White;
            this.AboutButton.Location = new System.Drawing.Point(1187, 4);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(29, 23);
            this.AboutButton.TabIndex = 2;
            this.AboutButton.Text = "?";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeButton.ForeColor = System.Drawing.Color.White;
            this.MaximizeButton.Location = new System.Drawing.Point(1220, 2);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(29, 23);
            this.MaximizeButton.TabIndex = 2;
            this.MaximizeButton.Text = "↗";
            this.MaximizeButton.UseVisualStyleBackColor = true;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(1253, 2);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(29, 23);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(1286, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(29, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AdministrationButton
            // 
            this.AdministrationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdministrationButton.FlatAppearance.BorderSize = 0;
            this.AdministrationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AdministrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdministrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdministrationButton.Image = ((System.Drawing.Image)(resources.GetObject("AdministrationButton.Image")));
            this.AdministrationButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AdministrationButton.Location = new System.Drawing.Point(1011, 36);
            this.AdministrationButton.Name = "AdministrationButton";
            this.AdministrationButton.Size = new System.Drawing.Size(97, 78);
            this.AdministrationButton.TabIndex = 1;
            this.AdministrationButton.Text = "Administración";
            this.AdministrationButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AdministrationButton.UseVisualStyleBackColor = true;
            this.AdministrationButton.Click += new System.EventHandler(this.AdministrationButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HomeButton.Location = new System.Drawing.Point(15, 36);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(93, 78);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "Inicio";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // ClientsButton
            // 
            this.ClientsButton.FlatAppearance.BorderSize = 0;
            this.ClientsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ClientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsButton.Image = ((System.Drawing.Image)(resources.GetObject("ClientsButton.Image")));
            this.ClientsButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ClientsButton.Location = new System.Drawing.Point(312, 36);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(93, 78);
            this.ClientsButton.TabIndex = 1;
            this.ClientsButton.Text = "Clientes";
            this.ClientsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ClientsButton.UseVisualStyleBackColor = true;
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.FlatAppearance.BorderSize = 0;
            this.EmployeesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.EmployeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesButton.Image = ((System.Drawing.Image)(resources.GetObject("EmployeesButton.Image")));
            this.EmployeesButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EmployeesButton.Location = new System.Drawing.Point(510, 36);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(93, 78);
            this.EmployeesButton.TabIndex = 1;
            this.EmployeesButton.Text = "Empleados";
            this.EmployeesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EmployeesButton.UseVisualStyleBackColor = true;
            this.EmployeesButton.Click += new System.EventHandler(this.EmployeesButton_Click);
            // 
            // ProductButton
            // 
            this.ProductButton.FlatAppearance.BorderSize = 0;
            this.ProductButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductButton.Image = ((System.Drawing.Image)(resources.GetObject("ProductButton.Image")));
            this.ProductButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ProductButton.Location = new System.Drawing.Point(213, 36);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(93, 78);
            this.ProductButton.TabIndex = 1;
            this.ProductButton.Text = "Productos";
            this.ProductButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ProductButton.UseVisualStyleBackColor = true;
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // BusinessButton
            // 
            this.BusinessButton.FlatAppearance.BorderSize = 0;
            this.BusinessButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BusinessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BusinessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusinessButton.Image = ((System.Drawing.Image)(resources.GetObject("BusinessButton.Image")));
            this.BusinessButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BusinessButton.Location = new System.Drawing.Point(411, 36);
            this.BusinessButton.Name = "BusinessButton";
            this.BusinessButton.Size = new System.Drawing.Size(93, 78);
            this.BusinessButton.TabIndex = 1;
            this.BusinessButton.Text = "Negocio";
            this.BusinessButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BusinessButton.UseVisualStyleBackColor = true;
            this.BusinessButton.Click += new System.EventHandler(this.BusinessButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SettingsButton.Location = new System.Drawing.Point(1114, 36);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(93, 78);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Configuración";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // AboutButton2
            // 
            this.AboutButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutButton2.FlatAppearance.BorderSize = 0;
            this.AboutButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AboutButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton2.Image = ((System.Drawing.Image)(resources.GetObject("AboutButton2.Image")));
            this.AboutButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AboutButton2.Location = new System.Drawing.Point(1213, 36);
            this.AboutButton2.Name = "AboutButton2";
            this.AboutButton2.Size = new System.Drawing.Size(93, 78);
            this.AboutButton2.TabIndex = 1;
            this.AboutButton2.Text = "Acerca";
            this.AboutButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AboutButton2.UseVisualStyleBackColor = true;
            this.AboutButton2.Click += new System.EventHandler(this.AboutButton2_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainPanel.Location = new System.Drawing.Point(12, 120);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1294, 639);
            this.MainPanel.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 768);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1318, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(140, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // PurchaseOrderButton
            // 
            this.PurchaseOrderButton.FlatAppearance.BorderSize = 0;
            this.PurchaseOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PurchaseOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurchaseOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("PurchaseOrderButton.Image")));
            this.PurchaseOrderButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PurchaseOrderButton.Location = new System.Drawing.Point(114, 36);
            this.PurchaseOrderButton.Name = "PurchaseOrderButton";
            this.PurchaseOrderButton.Size = new System.Drawing.Size(93, 78);
            this.PurchaseOrderButton.TabIndex = 1;
            this.PurchaseOrderButton.Text = "Facturación";
            this.PurchaseOrderButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PurchaseOrderButton.UseVisualStyleBackColor = true;
            this.PurchaseOrderButton.Click += new System.EventHandler(this.PurchaseOrderButton_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1318, 790);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.AboutButton2);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.BusinessButton);
            this.Controls.Add(this.ProductButton);
            this.Controls.Add(this.EmployeesButton);
            this.Controls.Add(this.ClientsButton);
            this.Controls.Add(this.PurchaseOrderButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.AdministrationButton);
            this.Controls.Add(this.DraggablePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.DraggablePanel.ResumeLayout(false);
            this.DraggablePanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DraggablePanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button AdministrationButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button ClientsButton;
        private System.Windows.Forms.Button EmployeesButton;
        private System.Windows.Forms.Button ProductButton;
        private System.Windows.Forms.Button BusinessButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button AboutButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button MaximizeButton;
        private System.Windows.Forms.Button PurchaseOrderButton;
    }
}

