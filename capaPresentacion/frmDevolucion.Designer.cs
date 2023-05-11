namespace capaPresentacion
{
    partial class frmDevolucion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFondo2 = new System.Windows.Forms.Panel();
            this.btnDevolverPrestamo = new FontAwesome.Sharp.IconButton();
            this.groupBoxDatosDevolucion = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdPrestamo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFechaRetorno = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureEmpleados = new FontAwesome.Sharp.IconPictureBox();
            this.PRESTAMOS = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvDevoluciones = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Retorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFondo2.SuspendLayout();
            this.groupBoxDatosDevolucion.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondo2
            // 
            this.pnlFondo2.Controls.Add(this.btnDevolverPrestamo);
            this.pnlFondo2.Controls.Add(this.groupBoxDatosDevolucion);
            this.pnlFondo2.Controls.Add(this.pnlHeader);
            this.pnlFondo2.Controls.Add(this.dgvDevoluciones);
            this.pnlFondo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo2.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo2.Name = "pnlFondo2";
            this.pnlFondo2.Size = new System.Drawing.Size(870, 540);
            this.pnlFondo2.TabIndex = 0;
            // 
            // btnDevolverPrestamo
            // 
            this.btnDevolverPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDevolverPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(66)))), ((int)(((byte)(116)))));
            this.btnDevolverPrestamo.FlatAppearance.BorderSize = 0;
            this.btnDevolverPrestamo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(66)))), ((int)(((byte)(116)))));
            this.btnDevolverPrestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(142)))));
            this.btnDevolverPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolverPrestamo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolverPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnDevolverPrestamo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnDevolverPrestamo.IconColor = System.Drawing.Color.White;
            this.btnDevolverPrestamo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDevolverPrestamo.IconSize = 30;
            this.btnDevolverPrestamo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDevolverPrestamo.Location = new System.Drawing.Point(737, 56);
            this.btnDevolverPrestamo.Name = "btnDevolverPrestamo";
            this.btnDevolverPrestamo.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.btnDevolverPrestamo.Size = new System.Drawing.Size(121, 87);
            this.btnDevolverPrestamo.TabIndex = 45;
            this.btnDevolverPrestamo.Text = "Devolver";
            this.btnDevolverPrestamo.UseVisualStyleBackColor = false;
            this.btnDevolverPrestamo.Click += new System.EventHandler(this.btnDevolverPrestamo_Click);
            // 
            // groupBoxDatosDevolucion
            // 
            this.groupBoxDatosDevolucion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDatosDevolucion.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDatosDevolucion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(216)))), ((int)(((byte)(239)))));
            this.groupBoxDatosDevolucion.BorderRadius = 5;
            this.groupBoxDatosDevolucion.Controls.Add(this.label7);
            this.groupBoxDatosDevolucion.Controls.Add(this.label5);
            this.groupBoxDatosDevolucion.Controls.Add(this.txtIdPrestamo);
            this.groupBoxDatosDevolucion.Controls.Add(this.txtFechaRetorno);
            this.groupBoxDatosDevolucion.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.groupBoxDatosDevolucion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBoxDatosDevolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBoxDatosDevolucion.Location = new System.Drawing.Point(12, 56);
            this.groupBoxDatosDevolucion.Name = "groupBoxDatosDevolucion";
            this.groupBoxDatosDevolucion.ShadowDecoration.Parent = this.groupBoxDatosDevolucion;
            this.groupBoxDatosDevolucion.Size = new System.Drawing.Size(719, 87);
            this.groupBoxDatosDevolucion.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(346, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha Retorno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID Prestamo";
            // 
            // txtIdPrestamo
            // 
            this.txtIdPrestamo.BorderColor = System.Drawing.Color.Gray;
            this.txtIdPrestamo.BorderRadius = 3;
            this.txtIdPrestamo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdPrestamo.DefaultText = "";
            this.txtIdPrestamo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdPrestamo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdPrestamo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPrestamo.DisabledState.Parent = this.txtIdPrestamo;
            this.txtIdPrestamo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPrestamo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPrestamo.FocusedState.Parent = this.txtIdPrestamo;
            this.txtIdPrestamo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPrestamo.ForeColor = System.Drawing.Color.Black;
            this.txtIdPrestamo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPrestamo.HoverState.Parent = this.txtIdPrestamo;
            this.txtIdPrestamo.Location = new System.Drawing.Point(109, 32);
            this.txtIdPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPrestamo.Name = "txtIdPrestamo";
            this.txtIdPrestamo.PasswordChar = '\0';
            this.txtIdPrestamo.PlaceholderText = "";
            this.txtIdPrestamo.SelectedText = "";
            this.txtIdPrestamo.ShadowDecoration.Parent = this.txtIdPrestamo;
            this.txtIdPrestamo.Size = new System.Drawing.Size(214, 27);
            this.txtIdPrestamo.TabIndex = 13;
            // 
            // txtFechaRetorno
            // 
            this.txtFechaRetorno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaRetorno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.txtFechaRetorno.BorderRadius = 3;
            this.txtFechaRetorno.BorderThickness = 1;
            this.txtFechaRetorno.CheckedState.Parent = this.txtFechaRetorno;
            this.txtFechaRetorno.FillColor = System.Drawing.Color.White;
            this.txtFechaRetorno.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaRetorno.ForeColor = System.Drawing.Color.Black;
            this.txtFechaRetorno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaRetorno.HoverState.Parent = this.txtFechaRetorno;
            this.txtFechaRetorno.Location = new System.Drawing.Point(456, 32);
            this.txtFechaRetorno.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaRetorno.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaRetorno.Name = "txtFechaRetorno";
            this.txtFechaRetorno.ShadowDecoration.Parent = this.txtFechaRetorno;
            this.txtFechaRetorno.Size = new System.Drawing.Size(248, 27);
            this.txtFechaRetorno.TabIndex = 6;
            this.txtFechaRetorno.Value = new System.DateTime(2022, 12, 27, 12, 18, 1, 33);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(66)))), ((int)(((byte)(116)))));
            this.pnlHeader.Controls.Add(this.pictureEmpleados);
            this.pnlHeader.Controls.Add(this.PRESTAMOS);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowDecoration.Parent = this.pnlHeader;
            this.pnlHeader.Size = new System.Drawing.Size(870, 50);
            this.pnlHeader.TabIndex = 46;
            // 
            // pictureEmpleados
            // 
            this.pictureEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(66)))), ((int)(((byte)(116)))));
            this.pictureEmpleados.IconChar = FontAwesome.Sharp.IconChar.StickyNote;
            this.pictureEmpleados.IconColor = System.Drawing.Color.White;
            this.pictureEmpleados.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.pictureEmpleados.IconSize = 25;
            this.pictureEmpleados.Location = new System.Drawing.Point(6, 13);
            this.pictureEmpleados.Name = "pictureEmpleados";
            this.pictureEmpleados.Size = new System.Drawing.Size(25, 25);
            this.pictureEmpleados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureEmpleados.TabIndex = 17;
            this.pictureEmpleados.TabStop = false;
            // 
            // PRESTAMOS
            // 
            this.PRESTAMOS.BackColor = System.Drawing.Color.Transparent;
            this.PRESTAMOS.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRESTAMOS.ForeColor = System.Drawing.SystemColors.Control;
            this.PRESTAMOS.Location = new System.Drawing.Point(34, 14);
            this.PRESTAMOS.Name = "PRESTAMOS";
            this.PRESTAMOS.Size = new System.Drawing.Size(400, 22);
            this.PRESTAMOS.TabIndex = 15;
            this.PRESTAMOS.Text = "Devoluciones, Libros que han sido regresados ala biblioteca";
            // 
            // dgvDevoluciones
            // 
            this.dgvDevoluciones.AllowUserToAddRows = false;
            this.dgvDevoluciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDevoluciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDevoluciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvDevoluciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDevoluciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvDevoluciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevoluciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDevoluciones.ColumnHeadersHeight = 32;
            this.dgvDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDevoluciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Empleado,
            this.Estudiante,
            this.Libro,
            this.Fecha_inicio,
            this.Fecha_fin,
            this.Estado,
            this.Fecha_Retorno});
            this.dgvDevoluciones.EnableHeadersVisualStyles = false;
            this.dgvDevoluciones.Location = new System.Drawing.Point(12, 161);
            this.dgvDevoluciones.Name = "dgvDevoluciones";
            this.dgvDevoluciones.ReadOnly = true;
            this.dgvDevoluciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDevoluciones.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDevoluciones.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDevoluciones.RowTemplate.Height = 25;
            this.dgvDevoluciones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDevoluciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevoluciones.Size = new System.Drawing.Size(846, 367);
            this.dgvDevoluciones.TabIndex = 47;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.FillWeight = 30F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Empleado
            // 
            this.Empleado.DataPropertyName = "empleado";
            this.Empleado.FillWeight = 120F;
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            // 
            // Estudiante
            // 
            this.Estudiante.DataPropertyName = "estudiante";
            this.Estudiante.FillWeight = 120F;
            this.Estudiante.HeaderText = "Estudiante";
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.ReadOnly = true;
            // 
            // Libro
            // 
            this.Libro.DataPropertyName = "libro";
            this.Libro.FillWeight = 150F;
            this.Libro.HeaderText = "Libro";
            this.Libro.Name = "Libro";
            this.Libro.ReadOnly = true;
            // 
            // Fecha_inicio
            // 
            this.Fecha_inicio.DataPropertyName = "fecha_inicio";
            this.Fecha_inicio.FillWeight = 90F;
            this.Fecha_inicio.HeaderText = "Fecha_inicio";
            this.Fecha_inicio.Name = "Fecha_inicio";
            this.Fecha_inicio.ReadOnly = true;
            // 
            // Fecha_fin
            // 
            this.Fecha_fin.DataPropertyName = "fecha_fin";
            this.Fecha_fin.FillWeight = 90F;
            this.Fecha_fin.HeaderText = "Fecha_fin";
            this.Fecha_fin.Name = "Fecha_fin";
            this.Fecha_fin.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "estado";
            this.Estado.FillWeight = 90F;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Fecha_Retorno
            // 
            this.Fecha_Retorno.DataPropertyName = "fecha_retorno";
            this.Fecha_Retorno.HeaderText = "Fecha_retorno";
            this.Fecha_Retorno.Name = "Fecha_Retorno";
            this.Fecha_Retorno.ReadOnly = true;
            // 
            // frmDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(870, 540);
            this.Controls.Add(this.pnlFondo2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDevolucion";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frmDevolucion_Load);
            this.pnlFondo2.ResumeLayout(false);
            this.groupBoxDatosDevolucion.ResumeLayout(false);
            this.groupBoxDatosDevolucion.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevoluciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo2;
        private FontAwesome.Sharp.IconButton btnDevolverPrestamo;
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxDatosDevolucion;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private FontAwesome.Sharp.IconPictureBox pictureEmpleados;
        private Guna.UI2.WinForms.Guna2HtmlLabel PRESTAMOS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtIdPrestamo;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtFechaRetorno;
        private System.Windows.Forms.DataGridView dgvDevoluciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Retorno;
    }
}