namespace capaPresentacion
{
    partial class frmLibros
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
            this.pnlFondo = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureEmpleados = new FontAwesome.Sharp.IconPictureBox();
            this.lblLibros = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.groupEmpleados = new System.Windows.Forms.GroupBox();
            this.btnModalAutores = new System.Windows.Forms.Label();
            this.cmbAutores = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.btnInsertarLibro = new System.Windows.Forms.Button();
            this.btnActualizarLibro = new System.Windows.Forms.Button();
            this.lblIDLibro = new System.Windows.Forms.Label();
            this.txtIdLibro = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbCategorias = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.txtPaginas = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmpleados)).BeginInit();
            this.groupEmpleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.Controls.Add(this.dgvLibros);
            this.pnlFondo.Controls.Add(this.pnlHeader);
            this.pnlFondo.Controls.Add(this.groupEmpleados);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.ShadowDecoration.Parent = this.pnlFondo;
            this.pnlFondo.Size = new System.Drawing.Size(876, 600);
            this.pnlFondo.TabIndex = 0;
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.BackgroundColor = System.Drawing.Color.White;
            this.dgvLibros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLibros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvLibros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLibros.ColumnHeadersHeight = 32;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Paginas,
            this.Stock,
            this.Categoria,
            this.Autor});
            this.dgvLibros.EnableHeadersVisualStyles = false;
            this.dgvLibros.Location = new System.Drawing.Point(12, 290);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLibros.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLibros.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLibros.RowTemplate.Height = 25;
            this.dgvLibros.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibros.Size = new System.Drawing.Size(852, 298);
            this.dgvLibros.TabIndex = 37;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 40F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.FillWeight = 150F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Paginas
            // 
            this.Paginas.DataPropertyName = "Paginas";
            this.Paginas.FillWeight = 50F;
            this.Paginas.HeaderText = "Paginas";
            this.Paginas.Name = "Paginas";
            this.Paginas.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.FillWeight = 50F;
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "Autor";
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(66)))), ((int)(((byte)(116)))));
            this.pnlHeader.Controls.Add(this.pictureEmpleados);
            this.pnlHeader.Controls.Add(this.lblLibros);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowDecoration.Parent = this.pnlHeader;
            this.pnlHeader.Size = new System.Drawing.Size(876, 50);
            this.pnlHeader.TabIndex = 35;
            // 
            // pictureEmpleados
            // 
            this.pictureEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(66)))), ((int)(((byte)(116)))));
            this.pictureEmpleados.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.pictureEmpleados.IconColor = System.Drawing.Color.White;
            this.pictureEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pictureEmpleados.IconSize = 25;
            this.pictureEmpleados.Location = new System.Drawing.Point(6, 13);
            this.pictureEmpleados.Name = "pictureEmpleados";
            this.pictureEmpleados.Size = new System.Drawing.Size(25, 25);
            this.pictureEmpleados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureEmpleados.TabIndex = 17;
            this.pictureEmpleados.TabStop = false;
            // 
            // lblLibros
            // 
            this.lblLibros.BackColor = System.Drawing.Color.Transparent;
            this.lblLibros.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibros.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLibros.Location = new System.Drawing.Point(37, 13);
            this.lblLibros.Name = "lblLibros";
            this.lblLibros.Size = new System.Drawing.Size(43, 22);
            this.lblLibros.TabIndex = 15;
            this.lblLibros.Text = "Libros";
            // 
            // groupEmpleados
            // 
            this.groupEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupEmpleados.BackColor = System.Drawing.Color.White;
            this.groupEmpleados.Controls.Add(this.btnModalAutores);
            this.groupEmpleados.Controls.Add(this.cmbAutores);
            this.groupEmpleados.Controls.Add(this.lblAutor);
            this.groupEmpleados.Controls.Add(this.btnInsertarLibro);
            this.groupEmpleados.Controls.Add(this.btnActualizarLibro);
            this.groupEmpleados.Controls.Add(this.lblIDLibro);
            this.groupEmpleados.Controls.Add(this.txtIdLibro);
            this.groupEmpleados.Controls.Add(this.cmbCategorias);
            this.groupEmpleados.Controls.Add(this.lblCategoria);
            this.groupEmpleados.Controls.Add(this.lblPaginas);
            this.groupEmpleados.Controls.Add(this.txtPaginas);
            this.groupEmpleados.Controls.Add(this.lblStock);
            this.groupEmpleados.Controls.Add(this.txtStock);
            this.groupEmpleados.Controls.Add(this.lblNombre);
            this.groupEmpleados.Controls.Add(this.txtNombre);
            this.groupEmpleados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupEmpleados.Location = new System.Drawing.Point(12, 73);
            this.groupEmpleados.Name = "groupEmpleados";
            this.groupEmpleados.Size = new System.Drawing.Size(852, 211);
            this.groupEmpleados.TabIndex = 36;
            this.groupEmpleados.TabStop = false;
            this.groupEmpleados.Text = "Datos del Libro";
            // 
            // btnModalAutores
            // 
            this.btnModalAutores.AutoSize = true;
            this.btnModalAutores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModalAutores.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModalAutores.ForeColor = System.Drawing.Color.Blue;
            this.btnModalAutores.Location = new System.Drawing.Point(582, 26);
            this.btnModalAutores.Name = "btnModalAutores";
            this.btnModalAutores.Size = new System.Drawing.Size(96, 17);
            this.btnModalAutores.TabIndex = 49;
            this.btnModalAutores.Text = "Agregar Autor";
            this.btnModalAutores.Click += new System.EventHandler(this.btnModalAutores_Click);
            // 
            // cmbAutores
            // 
            this.cmbAutores.BackColor = System.Drawing.Color.Transparent;
            this.cmbAutores.BorderColor = System.Drawing.Color.Gray;
            this.cmbAutores.BorderRadius = 3;
            this.cmbAutores.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAutores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutores.FillColor = System.Drawing.Color.Silver;
            this.cmbAutores.FocusedColor = System.Drawing.Color.Empty;
            this.cmbAutores.FocusedState.Parent = this.cmbAutores;
            this.cmbAutores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAutores.ForeColor = System.Drawing.Color.Black;
            this.cmbAutores.FormattingEnabled = true;
            this.cmbAutores.HoverState.Parent = this.cmbAutores;
            this.cmbAutores.ItemHeight = 23;
            this.cmbAutores.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmbAutores.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbAutores.ItemsAppearance.Parent = this.cmbAutores;
            this.cmbAutores.Location = new System.Drawing.Point(460, 47);
            this.cmbAutores.Name = "cmbAutores";
            this.cmbAutores.ShadowDecoration.Parent = this.cmbAutores;
            this.cmbAutores.Size = new System.Drawing.Size(218, 29);
            this.cmbAutores.TabIndex = 47;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(456, 24);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(49, 20);
            this.lblAutor.TabIndex = 48;
            this.lblAutor.Text = "Autor";
            // 
            // btnInsertarLibro
            // 
            this.btnInsertarLibro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInsertarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(66)))), ((int)(((byte)(116)))));
            this.btnInsertarLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertarLibro.FlatAppearance.BorderSize = 0;
            this.btnInsertarLibro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(66)))), ((int)(((byte)(116)))));
            this.btnInsertarLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(142)))));
            this.btnInsertarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertarLibro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarLibro.ForeColor = System.Drawing.Color.White;
            this.btnInsertarLibro.Location = new System.Drawing.Point(8, 169);
            this.btnInsertarLibro.Name = "btnInsertarLibro";
            this.btnInsertarLibro.Size = new System.Drawing.Size(90, 30);
            this.btnInsertarLibro.TabIndex = 7;
            this.btnInsertarLibro.Text = "Insertar";
            this.btnInsertarLibro.UseVisualStyleBackColor = false;
            this.btnInsertarLibro.Click += new System.EventHandler(this.btnInsertarLibro_Click);
            // 
            // btnActualizarLibro
            // 
            this.btnActualizarLibro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualizarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(66)))), ((int)(((byte)(116)))));
            this.btnActualizarLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarLibro.FlatAppearance.BorderSize = 0;
            this.btnActualizarLibro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(66)))), ((int)(((byte)(116)))));
            this.btnActualizarLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(142)))));
            this.btnActualizarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarLibro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarLibro.ForeColor = System.Drawing.Color.White;
            this.btnActualizarLibro.Location = new System.Drawing.Point(104, 169);
            this.btnActualizarLibro.Name = "btnActualizarLibro";
            this.btnActualizarLibro.Size = new System.Drawing.Size(90, 30);
            this.btnActualizarLibro.TabIndex = 8;
            this.btnActualizarLibro.Text = "Actualizar";
            this.btnActualizarLibro.UseVisualStyleBackColor = false;
            this.btnActualizarLibro.Click += new System.EventHandler(this.btnActualizarLibro_Click);
            // 
            // lblIDLibro
            // 
            this.lblIDLibro.AutoSize = true;
            this.lblIDLibro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDLibro.Location = new System.Drawing.Point(456, 88);
            this.lblIDLibro.Name = "lblIDLibro";
            this.lblIDLibro.Size = new System.Drawing.Size(64, 20);
            this.lblIDLibro.TabIndex = 46;
            this.lblIDLibro.Text = "ID Libro";
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
            this.txtIdLibro.Location = new System.Drawing.Point(460, 113);
            this.txtIdLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdLibro.Name = "txtIdLibro";
            this.txtIdLibro.PasswordChar = '\0';
            this.txtIdLibro.PlaceholderText = "";
            this.txtIdLibro.SelectedText = "";
            this.txtIdLibro.ShadowDecoration.Parent = this.txtIdLibro;
            this.txtIdLibro.Size = new System.Drawing.Size(220, 27);
            this.txtIdLibro.TabIndex = 6;
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategorias.BorderColor = System.Drawing.Color.Gray;
            this.cmbCategorias.BorderRadius = 3;
            this.cmbCategorias.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorias.FillColor = System.Drawing.Color.Silver;
            this.cmbCategorias.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCategorias.FocusedState.Parent = this.cmbCategorias;
            this.cmbCategorias.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategorias.ForeColor = System.Drawing.Color.Black;
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.HoverState.Parent = this.cmbCategorias;
            this.cmbCategorias.ItemHeight = 23;
            this.cmbCategorias.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmbCategorias.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbCategorias.ItemsAppearance.Parent = this.cmbCategorias;
            this.cmbCategorias.Location = new System.Drawing.Point(237, 113);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.ShadowDecoration.Parent = this.cmbCategorias;
            this.cmbCategorias.Size = new System.Drawing.Size(216, 29);
            this.cmbCategorias.TabIndex = 5;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(233, 88);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(84, 20);
            this.lblCategoria.TabIndex = 42;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginas.Location = new System.Drawing.Point(6, 88);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(66, 20);
            this.lblPaginas.TabIndex = 39;
            this.lblPaginas.Text = "Paginas";
            // 
            // txtPaginas
            // 
            this.txtPaginas.BorderColor = System.Drawing.Color.Gray;
            this.txtPaginas.BorderRadius = 3;
            this.txtPaginas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaginas.DefaultText = "";
            this.txtPaginas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPaginas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPaginas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaginas.DisabledState.Parent = this.txtPaginas;
            this.txtPaginas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaginas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaginas.FocusedState.Parent = this.txtPaginas;
            this.txtPaginas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaginas.ForeColor = System.Drawing.Color.Black;
            this.txtPaginas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaginas.HoverState.Parent = this.txtPaginas;
            this.txtPaginas.Location = new System.Drawing.Point(6, 113);
            this.txtPaginas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.PasswordChar = '\0';
            this.txtPaginas.PlaceholderText = "";
            this.txtPaginas.SelectedText = "";
            this.txtPaginas.ShadowDecoration.Parent = this.txtPaginas;
            this.txtPaginas.Size = new System.Drawing.Size(220, 27);
            this.txtPaginas.TabIndex = 1;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(233, 22);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(49, 20);
            this.lblStock.TabIndex = 35;
            this.lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.BorderColor = System.Drawing.Color.Gray;
            this.txtStock.BorderRadius = 3;
            this.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStock.DefaultText = "";
            this.txtStock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStock.DisabledState.Parent = this.txtStock;
            this.txtStock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStock.FocusedState.Parent = this.txtStock;
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.ForeColor = System.Drawing.Color.Black;
            this.txtStock.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStock.HoverState.Parent = this.txtStock;
            this.txtStock.Location = new System.Drawing.Point(233, 47);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStock.Name = "txtStock";
            this.txtStock.PasswordChar = '\0';
            this.txtStock.PlaceholderText = "";
            this.txtStock.SelectedText = "";
            this.txtStock.ShadowDecoration.Parent = this.txtStock;
            this.txtStock.Size = new System.Drawing.Size(220, 27);
            this.txtStock.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 33;
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
            this.txtNombre.Location = new System.Drawing.Point(6, 47);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.ShadowDecoration.Parent = this.txtNombre;
            this.txtNombre.Size = new System.Drawing.Size(220, 27);
            this.txtNombre.TabIndex = 0;
            // 
            // frmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 600);
            this.Controls.Add(this.pnlFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLibros";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.frmLibros_Load);
            this.pnlFondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmpleados)).EndInit();
            this.groupEmpleados.ResumeLayout(false);
            this.groupEmpleados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlFondo;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private FontAwesome.Sharp.IconPictureBox pictureEmpleados;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLibros;
        private System.Windows.Forms.GroupBox groupEmpleados;
        private System.Windows.Forms.Label btnModalAutores;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Button btnInsertarLibro;
        private System.Windows.Forms.Button btnActualizarLibro;
        private System.Windows.Forms.Label lblIDLibro;
        private Guna.UI2.WinForms.Guna2TextBox txtIdLibro;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategorias;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPaginas;
        private Guna.UI2.WinForms.Guna2TextBox txtPaginas;
        private System.Windows.Forms.Label lblStock;
        private Guna.UI2.WinForms.Guna2TextBox txtStock;
        private System.Windows.Forms.Label lblNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAutores;
    }
}