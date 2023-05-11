namespace capaPresentacion
{
    partial class frmPrestamos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFondo2 = new System.Windows.Forms.Panel();
            this.btnAgregarPrestamo = new FontAwesome.Sharp.IconButton();
            this.groupBoxDatosDevolucion = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmpleado = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFechaFin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtFechaInicio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.groupBoxDatosPrestamo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnBuscarLibro = new FontAwesome.Sharp.IconButton();
            this.btnBuscarEstudiante = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdLibro = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdEstudiante = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLibro = new System.Windows.Forms.Label();
            this.txtLibro = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.txtEstudiante = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureEmpleados = new FontAwesome.Sharp.IconPictureBox();
            this.PRESTAMOS = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
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
            this.groupBoxDatosPrestamo.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondo2
            // 
            this.pnlFondo2.Controls.Add(this.btnAgregarPrestamo);
            this.pnlFondo2.Controls.Add(this.groupBoxDatosDevolucion);
            this.pnlFondo2.Controls.Add(this.groupBoxDatosPrestamo);
            this.pnlFondo2.Controls.Add(this.pnlHeader);
            this.pnlFondo2.Controls.Add(this.dgvPrestamos);
            this.pnlFondo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo2.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo2.Name = "pnlFondo2";
            this.pnlFondo2.Size = new System.Drawing.Size(870, 540);
            this.pnlFondo2.TabIndex = 0;
            // 
            // btnAgregarPrestamo
            // 
            this.btnAgregarPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(66)))), ((int)(((byte)(116)))));
            this.btnAgregarPrestamo.FlatAppearance.BorderSize = 0;
            this.btnAgregarPrestamo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(66)))), ((int)(((byte)(116)))));
            this.btnAgregarPrestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(142)))));
            this.btnAgregarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPrestamo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPrestamo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarPrestamo.IconColor = System.Drawing.Color.White;
            this.btnAgregarPrestamo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarPrestamo.IconSize = 30;
            this.btnAgregarPrestamo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarPrestamo.Location = new System.Drawing.Point(737, 211);
            this.btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            this.btnAgregarPrestamo.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.btnAgregarPrestamo.Size = new System.Drawing.Size(121, 87);
            this.btnAgregarPrestamo.TabIndex = 45;
            this.btnAgregarPrestamo.Text = "Prestamo";
            this.btnAgregarPrestamo.UseVisualStyleBackColor = false;
            this.btnAgregarPrestamo.Click += new System.EventHandler(this.btnAgregarPrestamo_Click);
            // 
            // groupBoxDatosDevolucion
            // 
            this.groupBoxDatosDevolucion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDatosDevolucion.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDatosDevolucion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(216)))), ((int)(((byte)(239)))));
            this.groupBoxDatosDevolucion.BorderRadius = 5;
            this.groupBoxDatosDevolucion.Controls.Add(this.label7);
            this.groupBoxDatosDevolucion.Controls.Add(this.label6);
            this.groupBoxDatosDevolucion.Controls.Add(this.label5);
            this.groupBoxDatosDevolucion.Controls.Add(this.txtEmpleado);
            this.groupBoxDatosDevolucion.Controls.Add(this.txtFechaFin);
            this.groupBoxDatosDevolucion.Controls.Add(this.txtFechaInicio);
            this.groupBoxDatosDevolucion.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.groupBoxDatosDevolucion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBoxDatosDevolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBoxDatosDevolucion.Location = new System.Drawing.Point(12, 211);
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
            this.label7.Location = new System.Drawing.Point(326, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha Devolución";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(334, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha Prestamo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(22, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nombre del Empleado";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.BorderColor = System.Drawing.Color.Gray;
            this.txtEmpleado.BorderRadius = 3;
            this.txtEmpleado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmpleado.DefaultText = "";
            this.txtEmpleado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmpleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmpleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmpleado.DisabledState.Parent = this.txtEmpleado;
            this.txtEmpleado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmpleado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(217)))));
            this.txtEmpleado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmpleado.FocusedState.Parent = this.txtEmpleado;
            this.txtEmpleado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleado.ForeColor = System.Drawing.Color.Black;
            this.txtEmpleado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmpleado.HoverState.Parent = this.txtEmpleado;
            this.txtEmpleado.Location = new System.Drawing.Point(22, 44);
            this.txtEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.PasswordChar = '\0';
            this.txtEmpleado.PlaceholderText = "";
            this.txtEmpleado.ReadOnly = true;
            this.txtEmpleado.SelectedText = "";
            this.txtEmpleado.ShadowDecoration.Parent = this.txtEmpleado;
            this.txtEmpleado.Size = new System.Drawing.Size(262, 27);
            this.txtEmpleado.TabIndex = 13;
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaFin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.txtFechaFin.BorderRadius = 3;
            this.txtFechaFin.BorderThickness = 1;
            this.txtFechaFin.CheckedState.Parent = this.txtFechaFin;
            this.txtFechaFin.FillColor = System.Drawing.Color.White;
            this.txtFechaFin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaFin.ForeColor = System.Drawing.Color.Black;
            this.txtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaFin.HoverState.Parent = this.txtFechaFin;
            this.txtFechaFin.Location = new System.Drawing.Point(456, 44);
            this.txtFechaFin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaFin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.ShadowDecoration.Parent = this.txtFechaFin;
            this.txtFechaFin.Size = new System.Drawing.Size(248, 27);
            this.txtFechaFin.TabIndex = 6;
            this.txtFechaFin.Value = new System.DateTime(2022, 12, 27, 12, 18, 1, 33);
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaInicio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.txtFechaInicio.BorderRadius = 3;
            this.txtFechaInicio.BorderThickness = 1;
            this.txtFechaInicio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(217)))));
            this.txtFechaInicio.CheckedState.Parent = this.txtFechaInicio;
            this.txtFechaInicio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(217)))));
            this.txtFechaInicio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaInicio.ForeColor = System.Drawing.Color.Black;
            this.txtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaInicio.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(217)))));
            this.txtFechaInicio.HoverState.Parent = this.txtFechaInicio;
            this.txtFechaInicio.Location = new System.Drawing.Point(456, 11);
            this.txtFechaInicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaInicio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.ShadowDecoration.Parent = this.txtFechaInicio;
            this.txtFechaInicio.Size = new System.Drawing.Size(248, 27);
            this.txtFechaInicio.TabIndex = 5;
            this.txtFechaInicio.Value = new System.DateTime(2022, 12, 27, 12, 18, 1, 33);
            // 
            // groupBoxDatosPrestamo
            // 
            this.groupBoxDatosPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDatosPrestamo.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxDatosPrestamo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(216)))), ((int)(((byte)(239)))));
            this.groupBoxDatosPrestamo.BorderRadius = 5;
            this.groupBoxDatosPrestamo.Controls.Add(this.btnBuscarLibro);
            this.groupBoxDatosPrestamo.Controls.Add(this.btnBuscarEstudiante);
            this.groupBoxDatosPrestamo.Controls.Add(this.label4);
            this.groupBoxDatosPrestamo.Controls.Add(this.txtIdLibro);
            this.groupBoxDatosPrestamo.Controls.Add(this.label3);
            this.groupBoxDatosPrestamo.Controls.Add(this.txtIdEstudiante);
            this.groupBoxDatosPrestamo.Controls.Add(this.lblLibro);
            this.groupBoxDatosPrestamo.Controls.Add(this.txtLibro);
            this.groupBoxDatosPrestamo.Controls.Add(this.lblEstudiante);
            this.groupBoxDatosPrestamo.Controls.Add(this.txtEstudiante);
            this.groupBoxDatosPrestamo.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.groupBoxDatosPrestamo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBoxDatosPrestamo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBoxDatosPrestamo.Location = new System.Drawing.Point(12, 62);
            this.groupBoxDatosPrestamo.Name = "groupBoxDatosPrestamo";
            this.groupBoxDatosPrestamo.ShadowDecoration.Parent = this.groupBoxDatosPrestamo;
            this.groupBoxDatosPrestamo.Size = new System.Drawing.Size(846, 143);
            this.groupBoxDatosPrestamo.TabIndex = 48;
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(66)))), ((int)(((byte)(116)))));
            this.btnBuscarLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarLibro.FlatAppearance.BorderSize = 0;
            this.btnBuscarLibro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(66)))), ((int)(((byte)(116)))));
            this.btnBuscarLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(142)))));
            this.btnBuscarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarLibro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLibro.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscarLibro.IconColor = System.Drawing.Color.White;
            this.btnBuscarLibro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarLibro.IconSize = 20;
            this.btnBuscarLibro.Location = new System.Drawing.Point(700, 87);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(50, 27);
            this.btnBuscarLibro.TabIndex = 12;
            this.btnBuscarLibro.UseVisualStyleBackColor = false;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // btnBuscarEstudiante
            // 
            this.btnBuscarEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(66)))), ((int)(((byte)(116)))));
            this.btnBuscarEstudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarEstudiante.FlatAppearance.BorderSize = 0;
            this.btnBuscarEstudiante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(66)))), ((int)(((byte)(116)))));
            this.btnBuscarEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(142)))));
            this.btnBuscarEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEstudiante.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEstudiante.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscarEstudiante.IconColor = System.Drawing.Color.White;
            this.btnBuscarEstudiante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarEstudiante.IconSize = 20;
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(700, 42);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(50, 27);
            this.btnBuscarEstudiante.TabIndex = 11;
            this.btnBuscarEstudiante.UseVisualStyleBackColor = false;
            this.btnBuscarEstudiante.Click += new System.EventHandler(this.btnBuscarEstudiante_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(513, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Codigo:";
            // 
            // txtIdLibro
            // 
            this.txtIdLibro.BorderColor = System.Drawing.Color.Gray;
            this.txtIdLibro.BorderRadius = 3;
            this.txtIdLibro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdLibro.DefaultText = "";
            this.txtIdLibro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdLibro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdLibro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdLibro.DisabledState.Parent = this.txtIdLibro;
            this.txtIdLibro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdLibro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdLibro.FocusedState.Parent = this.txtIdLibro;
            this.txtIdLibro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdLibro.ForeColor = System.Drawing.Color.Black;
            this.txtIdLibro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdLibro.HoverState.Parent = this.txtIdLibro;
            this.txtIdLibro.Location = new System.Drawing.Point(581, 86);
            this.txtIdLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdLibro.Name = "txtIdLibro";
            this.txtIdLibro.PasswordChar = '\0';
            this.txtIdLibro.PlaceholderText = "";
            this.txtIdLibro.ReadOnly = true;
            this.txtIdLibro.SelectedText = "";
            this.txtIdLibro.ShadowDecoration.Parent = this.txtIdLibro;
            this.txtIdLibro.Size = new System.Drawing.Size(112, 27);
            this.txtIdLibro.TabIndex = 9;
            this.txtIdLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(513, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Codigo:";
            // 
            // txtIdEstudiante
            // 
            this.txtIdEstudiante.BorderColor = System.Drawing.Color.Gray;
            this.txtIdEstudiante.BorderRadius = 3;
            this.txtIdEstudiante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdEstudiante.DefaultText = "";
            this.txtIdEstudiante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdEstudiante.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdEstudiante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdEstudiante.DisabledState.Parent = this.txtIdEstudiante;
            this.txtIdEstudiante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdEstudiante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdEstudiante.FocusedState.Parent = this.txtIdEstudiante;
            this.txtIdEstudiante.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEstudiante.ForeColor = System.Drawing.Color.Black;
            this.txtIdEstudiante.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdEstudiante.HoverState.Parent = this.txtIdEstudiante;
            this.txtIdEstudiante.Location = new System.Drawing.Point(581, 42);
            this.txtIdEstudiante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdEstudiante.Name = "txtIdEstudiante";
            this.txtIdEstudiante.PasswordChar = '\0';
            this.txtIdEstudiante.PlaceholderText = "";
            this.txtIdEstudiante.ReadOnly = true;
            this.txtIdEstudiante.SelectedText = "";
            this.txtIdEstudiante.ShadowDecoration.Parent = this.txtIdEstudiante;
            this.txtIdEstudiante.Size = new System.Drawing.Size(112, 27);
            this.txtIdEstudiante.TabIndex = 7;
            this.txtIdEstudiante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.BackColor = System.Drawing.Color.White;
            this.lblLibro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibro.ForeColor = System.Drawing.Color.Black;
            this.lblLibro.Location = new System.Drawing.Point(18, 89);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(130, 20);
            this.lblLibro.TabIndex = 6;
            this.lblLibro.Text = "Nombre del Libro:";
            // 
            // txtLibro
            // 
            this.txtLibro.BorderColor = System.Drawing.Color.Gray;
            this.txtLibro.BorderRadius = 3;
            this.txtLibro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLibro.DefaultText = "";
            this.txtLibro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLibro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLibro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLibro.DisabledState.Parent = this.txtLibro;
            this.txtLibro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLibro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLibro.FocusedState.Parent = this.txtLibro;
            this.txtLibro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibro.ForeColor = System.Drawing.Color.Black;
            this.txtLibro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLibro.HoverState.Parent = this.txtLibro;
            this.txtLibro.Location = new System.Drawing.Point(187, 86);
            this.txtLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.PasswordChar = '\0';
            this.txtLibro.PlaceholderText = "";
            this.txtLibro.ReadOnly = true;
            this.txtLibro.SelectedText = "";
            this.txtLibro.ShadowDecoration.Parent = this.txtLibro;
            this.txtLibro.Size = new System.Drawing.Size(300, 27);
            this.txtLibro.TabIndex = 5;
            this.txtLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.BackColor = System.Drawing.Color.White;
            this.lblEstudiante.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante.ForeColor = System.Drawing.Color.Black;
            this.lblEstudiante.Location = new System.Drawing.Point(18, 45);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(165, 20);
            this.lblEstudiante.TabIndex = 4;
            this.lblEstudiante.Text = "Nombre del Estudiante:";
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.BorderColor = System.Drawing.Color.Gray;
            this.txtEstudiante.BorderRadius = 3;
            this.txtEstudiante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstudiante.DefaultText = "";
            this.txtEstudiante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEstudiante.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEstudiante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstudiante.DisabledState.Parent = this.txtEstudiante;
            this.txtEstudiante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstudiante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstudiante.FocusedState.Parent = this.txtEstudiante;
            this.txtEstudiante.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstudiante.ForeColor = System.Drawing.Color.Black;
            this.txtEstudiante.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstudiante.HoverState.Parent = this.txtEstudiante;
            this.txtEstudiante.Location = new System.Drawing.Point(187, 42);
            this.txtEstudiante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.PasswordChar = '\0';
            this.txtEstudiante.PlaceholderText = "";
            this.txtEstudiante.ReadOnly = true;
            this.txtEstudiante.SelectedText = "";
            this.txtEstudiante.ShadowDecoration.Parent = this.txtEstudiante;
            this.txtEstudiante.Size = new System.Drawing.Size(300, 27);
            this.txtEstudiante.TabIndex = 3;
            this.txtEstudiante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.pictureEmpleados.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
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
            this.PRESTAMOS.Size = new System.Drawing.Size(151, 22);
            this.PRESTAMOS.TabIndex = 15;
            this.PRESTAMOS.Text = "Registro de Prestamos";
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrestamos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvPrestamos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrestamos.ColumnHeadersHeight = 32;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Empleado,
            this.Estudiante,
            this.Libro,
            this.Fecha_inicio,
            this.Fecha_fin,
            this.Estado,
            this.Fecha_Retorno});
            this.dgvPrestamos.EnableHeadersVisualStyles = false;
            this.dgvPrestamos.Location = new System.Drawing.Point(12, 304);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPrestamos.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPrestamos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrestamos.RowTemplate.Height = 25;
            this.dgvPrestamos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(846, 224);
            this.dgvPrestamos.TabIndex = 47;
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
            // frmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(870, 540);
            this.Controls.Add(this.pnlFondo2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrestamos";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frmPrestamos_Load);
            this.pnlFondo2.ResumeLayout(false);
            this.groupBoxDatosDevolucion.ResumeLayout(false);
            this.groupBoxDatosDevolucion.PerformLayout();
            this.groupBoxDatosPrestamo.ResumeLayout(false);
            this.groupBoxDatosPrestamo.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo2;
        private FontAwesome.Sharp.IconButton btnAgregarPrestamo;
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxDatosDevolucion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtEmpleado;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtFechaFin;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtFechaInicio;
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxDatosPrestamo;
        private FontAwesome.Sharp.IconButton btnBuscarLibro;
        private FontAwesome.Sharp.IconButton btnBuscarEstudiante;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtIdLibro;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtIdEstudiante;
        private System.Windows.Forms.Label lblLibro;
        private Guna.UI2.WinForms.Guna2TextBox txtLibro;
        private System.Windows.Forms.Label lblEstudiante;
        private Guna.UI2.WinForms.Guna2TextBox txtEstudiante;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private FontAwesome.Sharp.IconPictureBox pictureEmpleados;
        private Guna.UI2.WinForms.Guna2HtmlLabel PRESTAMOS;
        private System.Windows.Forms.DataGridView dgvPrestamos;
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