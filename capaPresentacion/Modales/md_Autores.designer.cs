namespace capaPresentacion
{
    partial class md_Autores
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupDatosAutor = new System.Windows.Forms.GroupBox();
            this.btnActaulizar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtIdAutor = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupAutores = new System.Windows.Forms.GroupBox();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.groupDatosAutor.SuspendLayout();
            this.groupAutores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDatosAutor
            // 
            this.groupDatosAutor.Controls.Add(this.btnActaulizar);
            this.groupDatosAutor.Controls.Add(this.btnInsertar);
            this.groupDatosAutor.Controls.Add(this.lblStock);
            this.groupDatosAutor.Controls.Add(this.txtIdAutor);
            this.groupDatosAutor.Controls.Add(this.lblNombre);
            this.groupDatosAutor.Controls.Add(this.txtNombre);
            this.groupDatosAutor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDatosAutor.ForeColor = System.Drawing.Color.Black;
            this.groupDatosAutor.Location = new System.Drawing.Point(15, 12);
            this.groupDatosAutor.Name = "groupDatosAutor";
            this.groupDatosAutor.Size = new System.Drawing.Size(583, 119);
            this.groupDatosAutor.TabIndex = 3;
            this.groupDatosAutor.TabStop = false;
            this.groupDatosAutor.Text = "Detalle del Autor";
            // 
            // btnActaulizar
            // 
            this.btnActaulizar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActaulizar.Location = new System.Drawing.Point(92, 86);
            this.btnActaulizar.Name = "btnActaulizar";
            this.btnActaulizar.Size = new System.Drawing.Size(80, 27);
            this.btnActaulizar.TabIndex = 43;
            this.btnActaulizar.Text = "Actualizar";
            this.btnActaulizar.UseVisualStyleBackColor = true;
            this.btnActaulizar.Click += new System.EventHandler(this.btnActaulizar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(6, 86);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(80, 27);
            this.btnInsertar.TabIndex = 42;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(231, 22);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(69, 20);
            this.lblStock.TabIndex = 39;
            this.lblStock.Text = "ID Autor";
            // 
            // txtIdAutor
            // 
            this.txtIdAutor.BorderColor = System.Drawing.Color.Gray;
            this.txtIdAutor.BorderRadius = 3;
            this.txtIdAutor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdAutor.DefaultText = "";
            this.txtIdAutor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdAutor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdAutor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdAutor.DisabledState.Parent = this.txtIdAutor;
            this.txtIdAutor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdAutor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdAutor.FocusedState.Parent = this.txtIdAutor;
            this.txtIdAutor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAutor.ForeColor = System.Drawing.Color.Black;
            this.txtIdAutor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdAutor.HoverState.Parent = this.txtIdAutor;
            this.txtIdAutor.Location = new System.Drawing.Point(235, 47);
            this.txtIdAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdAutor.Name = "txtIdAutor";
            this.txtIdAutor.PasswordChar = '\0';
            this.txtIdAutor.PlaceholderText = "";
            this.txtIdAutor.SelectedText = "";
            this.txtIdAutor.ShadowDecoration.Parent = this.txtIdAutor;
            this.txtIdAutor.Size = new System.Drawing.Size(220, 27);
            this.txtIdAutor.TabIndex = 37;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 38;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderColor = System.Drawing.Color.Gray;
            this.txtNombre.BorderRadius = 3;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.Parent = this.txtNombre;
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.FocusedState.Parent = this.txtNombre;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.HoverState.Parent = this.txtNombre;
            this.txtNombre.Location = new System.Drawing.Point(7, 47);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.ShadowDecoration.Parent = this.txtNombre;
            this.txtNombre.Size = new System.Drawing.Size(220, 27);
            this.txtNombre.TabIndex = 36;
            // 
            // groupAutores
            // 
            this.groupAutores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAutores.Controls.Add(this.dgvAutores);
            this.groupAutores.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAutores.ForeColor = System.Drawing.Color.Black;
            this.groupAutores.Location = new System.Drawing.Point(12, 137);
            this.groupAutores.Name = "groupAutores";
            this.groupAutores.Size = new System.Drawing.Size(586, 233);
            this.groupAutores.TabIndex = 2;
            this.groupAutores.TabStop = false;
            this.groupAutores.Text = "Listado";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.FillWeight = 150F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 508;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // dgvAutores
            // 
            this.dgvAutores.AllowUserToAddRows = false;
            this.dgvAutores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAutores.BackgroundColor = System.Drawing.Color.White;
            this.dgvAutores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAutores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvAutores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAutores.ColumnHeadersHeight = 32;
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre});
            this.dgvAutores.EnableHeadersVisualStyles = false;
            this.dgvAutores.Location = new System.Drawing.Point(3, 26);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.ReadOnly = true;
            this.dgvAutores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAutores.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAutores.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAutores.RowTemplate.Height = 25;
            this.dgvAutores.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutores.Size = new System.Drawing.Size(577, 201);
            this.dgvAutores.TabIndex = 38;
            // 
            // md_Autores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(610, 382);
            this.Controls.Add(this.groupDatosAutor);
            this.Controls.Add(this.groupAutores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "md_Autores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Listado de Autores";
            this.Load += new System.EventHandler(this.md_Autores_Load);
            this.groupDatosAutor.ResumeLayout(false);
            this.groupDatosAutor.PerformLayout();
            this.groupAutores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupDatosAutor;
        private System.Windows.Forms.Label lblStock;
        private Guna.UI2.WinForms.Guna2TextBox txtIdAutor;
        private System.Windows.Forms.Label lblNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActaulizar;
        private System.Windows.Forms.GroupBox groupAutores;
        private System.Windows.Forms.DataGridView dgvAutores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}